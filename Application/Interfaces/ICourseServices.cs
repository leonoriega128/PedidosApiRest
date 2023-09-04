using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICourseServices
    {
        public CourseGetData SearchCourse(string courseCode);
        public string SaveCourse(Course cs);
        public string SaveDressItem(DressItem cs);

        public string SaveContractC(ContractC cs);

    }
}
