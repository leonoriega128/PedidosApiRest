
using Application.DTOs;
using Application.Interfaces;
using AutoMapper;
using Domain.Entities;
using Persistence;

namespace Application.Services
{
    public class CourseServices : ICourseServices
    {
        private readonly IUnitOfWork _unit;
        private readonly IMapper _mapper;

        public CourseServices(IUnitOfWork unit, IMapper mapper)
        {
            _unit = unit;
            _mapper = mapper;
        }

        public string SaveCourse(Course cs)
        {
            try
            {
                _unit.Courses.Create(cs);
                _unit.CompletedAsync().Wait();
                return ("ok");
            }catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        public string SaveContractC(ContractC cs)
        {
            try
            {
                _unit.ContractCs.Create(cs);
                _unit.CompletedAsync().Wait();
                return ("ok");
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }
        public string SaveDressItem(DressItem cs)
        {
            try
            {
                _unit.DressItems.Create(cs);
                _unit.CompletedAsync().Wait();
                return ("ok");
            }
            catch (Exception ex)
            {

                return ex.ToString();
            }
        }

        public CourseGetData SearchCourse(string courseCode)
        {
            List<CourseDTO> queryGetCourse = new();
            List<ContractCDTO> queryGetContract = new();
            List<DressItem> queryGetDressItem = new();
            List<Order> queryOrder = new();
            var NumberGraduatesAux = 0;
            var ItemName = "";
            var Price = 0;
            var Total = 0;


            var CourseQuery = _unit.Courses.FindByCondition(l => l.CourseCode.Contains(courseCode)).FirstOrDefault();
            
            //esta linea convierte de entidad a dto
            var dtocouseQuery = _mapper.Map<Course, CourseDTO>(CourseQuery);
            //esta linea convierte de dto a entidad
            //var couseQuery2 = _mapper.Map<CourseDTO, Course>(dtocouseQuery);

            if (CourseQuery != null)
            {
                var ContractQuery = _unit.ContractCs.FindByCondition(l => l.ContractId == CourseQuery.Id).ToList();
                if (ContractQuery != null)
                {
                    foreach (var item in ContractQuery)
                    {
                        var GetDressItem = _unit.DressItems.FindByCondition(l => l.Id == item.ItemId).ToList();
                        queryGetDressItem.AddRange(GetDressItem);
                    }
                }
            }
            foreach (var item in queryGetDressItem)
            {
                Order item2 = new Order();
                item2.NumberGraduates = CourseQuery.NumberGraduates;
                item2.Price = item.Price;
                item2.ItemName = item.Name;
                item2.Total = CourseQuery.NumberGraduates * item.Price;
                queryOrder.Add(item2);
            }


            var queryGetData =  new CourseGetData
                                     {
                                         CourseCode = CourseQuery.CourseCode,
                                         DischargeDate = CourseQuery.DischargeDate,
                                         CollegeName = CourseQuery.CollegeName,
                                         CollegeLevel = CourseQuery.CollegeLevel,
                                         CollegeCourse = CourseQuery.CollegeCourse,
                                         SchoolLocation = CourseQuery.SchoolLocation,
                                         Results = queryOrder,
                                         Total = CourseQuery.Total,
                                         DeliveryDate = CourseQuery.DeliveryDate
                                     };


            var result = queryGetData;
            return result;


        }

    }
}
