
USE ClinicaDB

create table Departamentos(
idDepartamento int identity(1,1) primary key,
nombre varchar(100)
)

go

create table Provincias(
idProvincia int identity(1,1) primary key,
nombre varchar(100),
idDepartamento int foreign key references Departamentos(idDepartamento)
)

GO

create table Distritos(
idDistrito int identity(1,1) primary key,
nombre varchar(100),
idProvincia int foreign key references Provincias(idProvincia)
)

GO

create table Personas(
idPersona int identity(1,1) primary key,
prNombre varchar(150),
sgNombre varchar(150),
aPaterno varchar(150),
aMaterno varchar(150),
fechaNacimiento datetime,
sexo varchar(20),
tipoDocumento varchar(100),
numDocumento varchar(100),
direccion varchar(300),
numDireccion varchar(50),
intDireccion varchar(50),
mzaDireccion varchar(50),
lteDireccion varchar(50),
telefono varchar(8),
celular varchar(9),
trabajo varchar(50),
discapacitado bit,
tipoLocalidad varchar(100),
nombreLocalidad varchar(100),
idDistrito int references Distritos(idDistrito),
estado int not null
)

GO

create table Empresas(
idEmpresa int identity(1,1) primary key,
nombre varchar(200),
veterinaria bit,
abreviado varchar(100),
giroNegocio varchar(400),
grupo varchar(150),
contacto varchar(200),
atencion varchar(200),
ruc varchar(20),
fechaConstitucion datetime,
fechaAniversario datetime,
cargo varchar(100),
direccion varchar(300),
idDistrito int references Distritos(idDistrito),
email varchar(100),
telefono varchar(30),
anexo varchar(30),
fax varchar(30),
homePage varchar(100),
observacion varchar(300),
estado int not null,
nombreUsuario varchar(200),
fechaCreacion datetime,
fechaModificacion datetime
)

go

create table Pacientes(
idPaciente int identity(1,1) primary key,
idPersona int foreign key references Personas(idPersona),
idEmpresa int references Empresas(idEmpresa),
numeroHistoria as (right('000000'+CONVERT([varchar](6),idPaciente),(6))),
tipoFinanciador varchar(100),
veterinaria bit,
observacion varchar(300),
estado int not null,
nombreUsuario varchar(200),
fechaCreacion datetime,
fechaModificacion datetime
)

go

-- MOMAZO --
create table Areas(
idArea int identity(1,1) primary key,
descripcion varchar(300),
breve varchar(300),
estado int not null
)

create table TiposTrabajador(
idTipoTrabajador int identity(1,1) primary key,
nombre varchar(200),
estado int not null
)

create table Trabajadores(
idTrabajador int identity(1,1) primary key,
idPersona int foreign key references Personas(idPersona),
idTipoTrabajador int references TiposTrabajador(idTipoTrabajador),
idArea int references Areas(idArea),
estado int not null,
nombreUsuario varchar(200),
fechaCreacion datetime,
fechaModificacion datetime
)

create table Muestras(
idMuestra int identity(1,1) primary key,
nombre varchar(200),
descripcion varchar(400),
estado int not null
)



create table Clases(
idClase int identity(1,1) primary key,
nombre varchar(300),
estado int not null
)

create table SubClases(
idSubClase int identity(1,1) primary key,
idClase int foreign key references Clases(idClase),
nombre varchar(300),
estado int not null
)

create table TipoAydDiags(
idTipoAydDiag int identity(1,1) primary key,
nombre varchar(500),
estado int not null
)

create table Cpts(
idCpt int identity(1,1) primary key,
descripcion varchar(400)
)

create table UnidadesMedida(
idUnidadMedida int identity(1,1) primary key,
codigo varchar(100),
descripcion varchar(300)
)

create table Servicios(
idServicio int identity(1,1) primary key,
nombre varchar(200),
descripcion varchar(200),
breve varchar(200),
idSubClase int references SubClases(idSubClase),
idUnidadMedida int references UnidadesMedida(idUnidadMedida),
idArea int references Areas(idArea),
importeBase varchar(10),
veterinaria bit,
categSocial bit,
categTemporal bit,
tarifaLibre bit, --QUEJESTO--
igv bit,
idTipoAydDiag int references TipoAydDiags(idTipoAydDiag),
idCpt int references Cpts(idCpt),
observacion varchar(400),
tipoServicio varchar(200),--QUEJESTO--
estado int
)

create table MuestrasServicios(
idServicio int foreign key references Servicios(idServicio) not null,
idMuestra int foreign key references Muestras(idMuestra) not null
)

create table Tarifas(
idTarifa int identity(1,1) primary key,
idServicio int references Servicios(idServicio),
tipoFinanciador varchar(100),
precioCalculado decimal(8,2),
precioExcepcion decimal(8,2),
tarifa varchar(200),--QUEJESTO
observacion varchar(400),
estado int
)

create table Usuarios(
idUsuario int identity(1,1) primary key,
idTrabajador int foreign key references Trabajadores(idTrabajador),
nombre varchar(50) unique,
clave varchar(70),
estado int not null
)

create table Descuentos(
idDescuento int identity(1,1) primary key,
nombre varchar(400),
estado int not null)

create table Incentivos(
idIncentivo int identity(1,1) primary key,
nombre varchar(400),
estado int not null
)
create table RazonesFinancieras(
idRazonFinanciera int identity(1,1) primary key,
nombre varchar(500),
tipo varchar(90), --ingreso, egreso-
)
create table Sueldos(
idSueldo int identity(1,1) primary key,
idTrabajador int foreign key references Trabajadores(idTrabajador),
fecha datetime,
montoBase decimal(10,4),
cantidadDeServicios int,
montoTotalPorServicios decimal (10,4),
estadoDePago int not null,
idRazonFinanciera int foreign key references RazonesFinancieras(idRazonFinanciera)
)
create table TrabajadorDescuentos(
idTrabajador int foreign key references Trabajadores(idTrabajador),
monto decimal(10,5),
idDescuento int foreign key references Descuentos(idDescuento),
estado int not null,
fecha datetime,
idSueldo int foreign key references Sueldos(idSueldo),
observacion varchar(500)
)
create table TrabajadorIncentivo(
idTrabajador int foreign key references Trabajadores(idTrabajador),
monto decimal(10,5),
idIncentivo int foreign key references Incentivos(idIncentivo),
estado int not null,
fecha datetime,
idSueldo int foreign key references Sueldos(idSueldo),
observacion varchar(500)
)

create table Egresos(
idEgreso int identity(1,1) primary key,
observacion varchar(500),
monto decimal(10,4),
fecha datetime,
idRazonFinanciera int foreign key references RazonesFinancieras(idRazonFinanciera)
)
create table Ingresos(
idIngreso int identity(1,1) primary key,
observacion varchar(500),
monto decimal (10,4),
fecha datetime,
idRazonFinanciera int foreign key references RazonesFinancieras(idRazonFinanciera)
)
create table Roles(
idRol int identity(1,1) primary key,
nombreRol varchar(500),
estado int not null
)

create table TrabajadorRol(
idTrabajador int foreign key references Trabajadores(idTrabajador) not null,
idRol int foreign key references Roles(idRol) not null
)
