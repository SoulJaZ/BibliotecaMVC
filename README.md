# CRUD Biblioteca  

Este proyecto es una aplicación web para la gestión de libros y autores en una biblioteca. Permite realizar operaciones CRUD (Crear, Leer, Actualizar y Eliminar) sobre libros y autores utilizando ASP.NET MVC y Entity Framework.

## Tecnologías Utilizadas  
- ASP.NET MVC  
- Entity Framework  
- SQL Server  
- Bootstrap  

## 📂 Instalación  

1. Clonar el repositorio:  
   git clone https://github.com/SoulJaZ/BibliotecaMVC.git
   cd BIBLIOTECA-V3
2. Crear la base de datos ejecutando el script database.sql en SQL Server.
3. Configurar la conexión en Web.config:
    <connectionStrings>
      <add name="BibliotecaContext" connectionString="Server=SU_SERVIDOR;Database=Biblioteca;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
    </connectionStrings>


