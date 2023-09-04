Hola! Para migrar la base se debe ingresar al PackageManagerConsole. En la ventana seleccionamos src\Infraestructure\Persistence y 
escribimos el siguiente comando: add-migration Leo -o Migrations (se debe configurar el appsettings para que apunte al local Server=localhost;Port=3306;Database=leo;Uid=root;Pwd=root;) 
y cuando termine de generarse se da la siguiente instruccion "update-database".
