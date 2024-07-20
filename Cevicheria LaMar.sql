-- Creación de la base de datos LAMAR
CREATE DATABASE LAMAR; 
USE LAMAR;

-- Creación de la tabla Usuario
CREATE TABLE Usuario(
    UsuarioId int NOT NULL   IDENTITY(1, 1),
    Nombre_Usuario VARCHAR(50)NOT NULL,
    Contrasena VARCHAR(50) NOT NULL,
    Rol VARCHAR(50) NOT NULL,
	CONSTRAINT Usuario_pk PRIMARY KEY  (UsuarioId)

);

-- Creación de la tabla Mesas_Inventario
CREATE TABLE Mesas_Inventario (
	ID_Mesa int  NOT NULL IDENTITY(1, 1),
    Codigo VARCHAR(20)NOT NULL,
    Capacidad INT NOT NULL,
    UsuarioModificacion VARCHAR(50) NOT NULL,
    UsuarioCreacion VARCHAR(50) NOT NULL,
    FechaCreacion DATETIME NOT NULL,
    FechaModificacion DATETIME NOT NULL,
	Estado VARCHAR(20) NOT NULL,
    Eliminado BIT NOT NULL,
	CONSTRAINT Mesas_Inventario_pk PRIMARY KEY  (ID_Mesa)
);

-- Creación de la tabla Reserva
CREATE TABLE Reserva (
	ID_Reserva int  NOT NULL IDENTITY(1, 1),
    Nombre_Cliente VARCHAR(50) NOT NULL,
    Numero_Personas INT NOT NULL,
    FechayHora_Reserva DATETIME NOT NULL,
    UsuarioModificacion VARCHAR(50) NOT NULL,
    FechaModificacion DATETIME NOT NULL,
    FechaCreacion DATETIME NOT NULL,
    UsuarioCreacion VARCHAR(50) NOT NULL,
    Estado VARCHAR(20) NOT NULL,
    Eliminado BIT NOT NULL,
	CONSTRAINT Reserva_pk PRIMARY KEY  (ID_Reserva)

);

-- Creación de la tabla Platos_Inventario
CREATE TABLE Platos_Inventario (
	ID_Plato int  NOT NULL IDENTITY(1, 1),
    Nombre_Plato VARCHAR(50)NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Categoria VARCHAR(30) NOT NULL,
    UsuarioModificacion VARCHAR(50) NOT NULL,
    UsuarioCreacion VARCHAR(50) NOT NULL,
    FechaCreacion DATETIME NOT NULL,
    FechaModificacion DATETIME NOT NULL,
    Eliminado BIT NOT NULL,
	CONSTRAINT Platos_Inventario_pk PRIMARY KEY  (ID_Plato)

);

-- Creación de la tabla Mesa_Reserva
CREATE TABLE Mesa_Reserva (
	ID_Mesa_Admin int  NOT NULL IDENTITY(1, 1),
    FechayHora_Reserva DATETIME NOT NULL,
    UsuarioModificacion VARCHAR(50) NOT NULL,
    UsuarioCreacion VARCHAR(50) NOT NULL,
    FechaModificacion DATETIME NOT NULL,
    FechaCreacion DATETIME NOT NULL,
    Reserva_Admin_ID_Reserva_Ad INT NOT NULL,
    Mesas_Inventario_ID_Plato INT NOT NULL,
    Eliminado BIT NOT NULL,
	CONSTRAINT Mesa_Reserva_pk PRIMARY KEY  (ID_Mesa_Admin)
);

-- Creación de la tabla Plato_Reserva
CREATE TABLE Plato_Reserva (
	ID_Plato_Admin int  NOT NULL IDENTITY(1, 1),
    UsuarioModificacion VARCHAR(50) NOT NULL,
    UsuarioCreacion VARCHAR(50) NOT NULL,
    FechaCreacion DATETIME NOT NULL,
    FechaModificacion DATETIME NOT NULL,
    Reserva_Admin_ID_Reserva_Admin INT NOT NULL,
    Platos_Inventario_ID_Plato INT NOT NULL,
    Eliminado BIT NOT NULL,
	CONSTRAINT Plato_Reserva_pk PRIMARY KEY  (ID_Plato_Admin)
);

ALTER TABLE Mesa_Reserva
ADD CONSTRAINT FK_Mesa_Reserva_Reserva FOREIGN KEY (Reserva_Admin_ID_Reserva_Ad) REFERENCES Reserva(ID_Reserva);

ALTER TABLE Mesa_Reserva
ADD CONSTRAINT FK_Mesa_Reserva_Mesas_Inventario FOREIGN KEY (Mesas_Inventario_ID_Plato) REFERENCES Mesas_Inventario(ID_Mesa);

ALTER TABLE Plato_Reserva
ADD CONSTRAINT FK_Plato_Reserva_Reserva FOREIGN KEY (Reserva_Admin_ID_Reserva_Admin) REFERENCES Reserva(ID_Reserva);

ALTER TABLE Plato_Reserva
ADD CONSTRAINT FK_Plato_Reserva_Platos_Inventario FOREIGN KEY (Platos_Inventario_ID_Plato) REFERENCES Platos_Inventario(ID_Plato);

INSERT INTO Usuario (Nombre_Usuario, Contrasena, Rol) VALUES
('admin', 'admin123', 'Administrador'),
('jgarcia', 'password1', 'Empleado'),
('mlopez', 'password2', 'Empleado');

INSERT INTO Mesas_Inventario (Codigo, Capacidad, UsuarioModificacion, UsuarioCreacion, FechaCreacion, FechaModificacion, Estado, Eliminado)
VALUES 
('MESA001', 4, 'jgarcia', 'jgarcia', '2024-01-01 10:00:00', '2024-01-01 10:00:00', 'Disponible', 0),
('MESA002', 2, 'mlopez', 'mlopez', '2024-01-02 11:00:00', '2024-01-02 11:00:00', 'Ocupada', 0),
('MESA003', 6, 'jgarcia', 'jgarcia', '2024-01-03 12:00:00', '2024-01-03 12:00:00', 'Disponible', 0),
('MESA004', 4, 'mlopez', 'mlopez', '2024-01-04 13:00:00', '2024-01-04 13:00:00', 'Reservada', 0),
('MESA005', 8, 'jgarcia', 'jgarcia', '2024-01-05 14:00:00', '2024-01-05 14:00:00', 'Disponible', 0),
('MESA006', 2, 'mlopez', 'mlopez', '2024-01-06 15:00:00', '2024-01-06 15:00:00', 'Ocupada', 0),
('MESA007', 4, 'jgarcia', 'jgarcia', '2024-01-07 16:00:00', '2024-01-07 16:00:00', 'Disponible', 0),
('MESA008', 6, 'mlopez', 'mlopez', '2024-01-08 17:00:00', '2024-01-08 17:00:00', 'Reservada', 0),
('MESA009', 8, 'jgarcia', 'jgarcia', '2024-01-09 18:00:00', '2024-01-09 18:00:00', 'Disponible', 0),
('MESA010', 4, 'mlopez', 'mlopez', '2024-01-10 19:00:00', '2024-01-10 19:00:00', 'Ocupada', 0);

INSERT INTO Reserva (Nombre_Cliente, Numero_Personas, FechayHora_Reserva, UsuarioModificacion, FechaModificacion, FechaCreacion, UsuarioCreacion, Estado, Eliminado)
VALUES
('Juan Pérez', 4, '2024-02-01 19:00:00', 'jgarcia', '2024-02-01 10:00:00', '2024-02-01 10:00:00', 'jgarcia', 'Pendiente', 0),
('María Gómez', 2, '2024-02-02 20:00:00', 'mlopez', '2024-02-02 11:00:00', '2024-02-02 11:00:00', 'mlopez', 'Confirmada', 0),
('Carlos Díaz', 6, '2024-02-03 21:00:00', 'jgarcia', '2024-02-03 12:00:00', '2024-02-03 12:00:00', 'jgarcia', 'Pendiente', 0),
('Ana López', 3, '2024-02-04 19:30:00', 'mlopez', '2024-02-04 13:00:00', '2024-02-04 13:00:00', 'mlopez', 'Cancelada', 0),
('Pedro Martínez', 5, '2024-02-05 18:00:00', 'jgarcia', '2024-02-05 14:00:00', '2024-02-05 14:00:00', 'jgarcia', 'Confirmada', 0),
('Lucía Fernández', 2, '2024-02-06 20:30:00', 'mlopez', '2024-02-06 15:00:00', '2024-02-06 15:00:00', 'mlopez', 'Pendiente', 0),
('Jorge García', 4, '2024-02-07 21:00:00', 'jgarcia', '2024-02-07 16:00:00', '2024-02-07 16:00:00', 'jgarcia', 'Confirmada', 0),
('Sofía Herrera', 6, '2024-02-08 19:00:00', 'mlopez', '2024-02-08 17:00:00', '2024-02-08 17:00:00', 'mlopez', 'Cancelada', 0),
('Raúl Torres', 3, '2024-02-09 20:00:00', 'jgarcia', '2024-02-09 18:00:00', '2024-02-09 18:00:00', 'jgarcia', 'Pendiente', 0),
('Natalia Ruiz', 4, '2024-02-10 21:00:00', 'mlopez', '2024-02-10 19:00:00', '2024-02-10 19:00:00', 'mlopez', 'Confirmada', 0);

INSERT INTO Platos_Inventario (Nombre_Plato, Precio, Categoria, UsuarioModificacion, UsuarioCreacion, FechaCreacion, FechaModificacion, Eliminado)
VALUES
('Ceviche', 20.00, 'Platos Marinos', 'jgarcia', 'jgarcia', '2024-03-01 10:00:00', '2024-03-01 10:00:00', 0),
('Tiradito', 18.50, 'Platos Marinos', 'mlopez', 'mlopez', '2024-03-02 11:00:00', '2024-03-02 11:00:00', 0),
('Jalea', 22.00, 'Platos Marinos', 'jgarcia', 'jgarcia', '2024-03-03 12:00:00', '2024-03-03 12:00:00', 0),
('Arroz con Mariscos', 24.50, 'Platos Marinos', 'mlopez', 'mlopez', '2024-03-04 13:00:00', '2024-03-04 13:00:00', 0),
('Chupe de Camarones', 19.00, 'Platos Marinos', 'jgarcia', 'jgarcia', '2024-03-05 14:00:00', '2024-03-05 14:00:00', 0),
('Sudado de Pescado', 21.50, 'Platos Marinos', 'mlopez', 'mlopez', '2024-03-06 15:00:00', '2024-03-06 15:00:00', 0),
('Pescado a la Chorrillana', 23.00, 'Platos Marinos', 'jgarcia', 'jgarcia', '2024-03-07 16:00:00', '2024-03-07 16:00:00', 0),
('Leche de Tigre', 15.50, 'Platos Marinos', 'mlopez', 'mlopez', '2024-03-08 17:00:00', '2024-03-08 17:00:00', 0),
('Chicharrón de Calamar', 17.00, 'Platos Marinos', 'jgarcia', 'jgarcia', '2024-03-09 18:00:00', '2024-03-09 18:00:00', 0),
('Parihuela', 25.00, 'Platos Marinos', 'mlopez', 'mlopez', '2024-03-10 19:00:00', '2024-03-10 19:00:00', 0);

INSERT INTO Mesa_Reserva (FechayHora_Reserva, UsuarioModificacion, UsuarioCreacion, FechaModificacion, FechaCreacion, Reserva_Admin_ID_Reserva_Ad, Mesas_Inventario_ID_Plato, Eliminado)
VALUES
('2024-02-01 19:00:00', 'jgarcia', 'jgarcia', '2024-01-01 10:00:00', '2024-01-01 10:00:00', 1, 1, 0),
('2024-02-02 20:00:00', 'mlopez', 'mlopez', '2024-01-02 11:00:00', '2024-01-02 11:00:00', 2, 2, 0),
('2024-02-03 21:00:00', 'jgarcia', 'jgarcia', '2024-01-03 12:00:00', '2024-01-03 12:00:00', 3, 3, 0),
('2024-02-04 19:30:00', 'mlopez', 'mlopez', '2024-01-04 13:00:00', '2024-01-04 13:00:00', 4, 4, 0),
('2024-02-05 18:00:00', 'jgarcia', 'jgarcia', '2024-01-05 14:00:00', '2024-01-05 14:00:00', 5, 5, 0),
('2024-02-06 20:30:00', 'mlopez', 'mlopez', '2024-01-06 15:00:00', '2024-01-06 15:00:00', 6, 6, 0),
('2024-02-07 21:00:00', 'jgarcia', 'jgarcia', '2024-01-07 16:00:00', '2024-01-07 16:00:00', 7, 7, 0),
('2024-02-08 19:00:00', 'mlopez', 'mlopez', '2024-01-08 17:00:00', '2024-01-08 17:00:00', 8, 8, 0),
('2024-02-09 20:00:00', 'jgarcia', 'jgarcia', '2024-01-09 18:00:00', '2024-01-09 18:00:00', 9, 9, 0),
('2024-02-10 21:00:00', 'mlopez', 'mlopez', '2024-01-10 19:00:00', '2024-01-10 19:00:00', 10, 10, 0);

INSERT INTO Plato_Reserva (UsuarioModificacion, UsuarioCreacion, FechaCreacion, FechaModificacion, Reserva_Admin_ID_Reserva_Admin, Platos_Inventario_ID_Plato, Eliminado)
VALUES
('jgarcia', 'jgarcia', '2024-03-01 10:00:00', '2024-03-01 10:00:00', 1, 1, 0),
('mlopez', 'mlopez', '2024-03-02 11:00:00', '2024-03-02 11:00:00', 2, 2, 0),
('jgarcia', 'jgarcia', '2024-03-03 12:00:00', '2024-03-03 12:00:00', 3, 3, 0),
('mlopez', 'mlopez', '2024-03-04 13:00:00', '2024-03-04 13:00:00', 4, 4, 0),
('jgarcia', 'jgarcia', '2024-03-05 14:00:00', '2024-03-05 14:00:00', 5, 5, 0),
('mlopez', 'mlopez', '2024-03-06 15:00:00', '2024-03-06 15:00:00', 6, 6, 0),
('jgarcia', 'jgarcia', '2024-03-07 16:00:00', '2024-03-07 16:00:00', 7, 7, 0),
('mlopez', 'mlopez', '2024-03-08 17:00:00', '2024-03-08 17:00:00', 8, 8, 0),
('jgarcia', 'jgarcia', '2024-03-09 18:00:00', '2024-03-09 18:00:00', 9, 9, 0),
('mlopez', 'mlopez', '2024-03-10 19:00:00', '2024-03-10 19:00:00', 10, 10, 0);
