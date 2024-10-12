Ejecuci�n:

	ruta de ejecucion: dentro de carpeta "CsharpCodeChallenge" a nivel de "Program.cs"
	ejecutar: dotnet  run

	nota: la DB est� en la nube, solo es ejecutar y ya se conecta a la DB.

Base de datos:

	DB: SQL Server
	AWS: RDS
	Credenciales de prueba: Appsettings.json

Tablas de DB:

	query en: SQL_DB_tablas.sql     --Crea la DB, tablas e inserta datos
	nota de dise�o: 
		Tablas "Users" necesaria para crear una relacion en tabla "Favorite_TV"
		donde se relaciona tabla "Programs_TV" con "Users".
		Para mantener la concistencia de los datos, en la tabla "Favorite_TV" se actualiza 
		a no favorito en  vez de eliminar  el registro.
		Si que  quiere agregar como favorito nuevamente, solo se actualiza la columna "isFavorite".

Acceso a DB:

	Repository: operaciones senciallas como obtener un registro de tabla "Programs_TV" y actualizar un 
				registro de "Favorite_TV"
	LINQ: operaciones complejas como join y where en tablas "Programs_TV" y "Favorite_TV" de el usuario. 
		  As� teniendo  todos los programas y con info de los favoritos.

Unit Test:

	xUnit

Decisi�n: 

	Uso de Base de datos: usar un entorno real en las configuraciones con DB.
	Estructura de carpetas: Mayor orden en un proyecto peque�o y familiaridad con proyectos de similar tama�o.
	Usar "Appsettings.json" para variables de entorno y porder cambiar con facilidad las credenciales de conexion.

