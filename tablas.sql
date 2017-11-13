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
idLugarNacimiento int references Distritos(idDistrito),
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
tipoFinanciador varchar(100),
veterinaria bit,
observacion varchar(300),
estado int not null,
nombreUsuario varchar(200),
fechaCreacion datetime,
fechaModificacion datetime
)

go

create table Historias(
idPaciente int foreign key references Pacientes(idPaciente),
numeroHistoria as (right('000000'+CONVERT([varchar](6),idPaciente),(6))),
fechaApertura datetime,
estado int not null
)

go

-- MOMAZO --
create table Areas(
idArea int identity(1,1) primary key,
descripcion varchar(300),
breve varchar(300),
estado int not null
)
go
create table TiposTrabajador(
idTipoTrabajador int identity(1,1) primary key,
nombre varchar(200),
estado int not null
)
go
create table Trabajadores(
idTrabajador int identity(1,1) primary key,
idPersona int foreign key references Personas(idPersona),
idTipoTrabajador int foreign key references TiposTrabajador(idTipoTrabajador),
idArea int references Areas(idArea),
estado int not null,
nombreUsuario varchar(200),
fechaCreacion datetime,
fechaModificacion datetime
)
go
create table Muestras(
idMuestra int identity(1,1) primary key,
nombre varchar(200),
descripcion varchar(400),
estado int not null
)
go
create table Clases(
idClase int identity(1,1) primary key,
nombre varchar(300),
estado int not null
)
go
create table SubClases(
idSubClase int identity(1,1) primary key,
idClase int foreign key references Clases(idClase),
nombre varchar(300),
estado int not null
)
go
create table TipoAydDiags(
idTipoAydDiag int identity(1,1) primary key,
nombre varchar(500),
estado int not null
)
go
create table Cpts(
idCpt int identity(1,1) primary key,
descripcion varchar(400)
)
go
create table UnidadesMedida(
idUnidadMedida int identity(1,1) primary key,
codigo varchar(100),
descripcion varchar(300)
)
go
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
go
create table MuestrasServicios(
idServicio int foreign key references Servicios(idServicio),
idMuestra int foreign key references Muestras(idMuestra)
)
go
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
go