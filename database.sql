CREATE DATABASE BibliotecaDB;
GO
USE BibliotecaDB;

-- Crear tabla Autores
CREATE TABLE Autors (
    AutorID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL
);

-- Crear tabla Libros
CREATE TABLE Libroes (
    LibroID INT IDENTITY(1,1) PRIMARY KEY,
    Titulo NVARCHAR(255) NOT NULL,
    AutorID INT NOT NULL,
    FOREIGN KEY (AutorID) REFERENCES Autores(AutorID) ON DELETE CASCADE
);
