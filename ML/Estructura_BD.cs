using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    internal class Estructura_BD
    {
        /*
        
        TABLES: Libro
        IdLibro	int
        Titulo	varchar(MAX)
        Editorial	varchar(MAX)
        FechaPublicacion	date
        Genero	varchar(20)
        NumPaginas	int
        Precio	decimal(10, 2)
        Stock	int
	
        =======================================================

        STORED PROCEDURES

        CREATE PROCEDURE LibrosGetAll
        AS
	        SELECT Libro.IdLibro,
		           Libro.Titulo,
		           Libro.Editorial,
		           Libro.FechaPublicacion,
		           Libro.Genero,
		           Libro.NumPaginas,
		           Libro.Precio,
		           Libro.Stock
	        FROM Libro



        CREATE PROCEDURE LibrosAdd
		@Titulo VARCHAR (MAX),
		@Editorial VARCHAR (MAX),
		@FechaPublicacion VARCHAR(20),
		@Genero VARCHAR(20),
		@NumPaginas INT,
		@Precio DECIMAL(10,2),
		@Stock INT
		AS 
			BEGIN 
				INSERT INTO Libro (Titulo,
								   Editorial,
								   FechaPublicacion,
								   Genero,
								   NumPaginas,
								   Precio,
								   Stock)
						   VALUES (@Titulo,
								   @Editorial,
								   @FechaPublicacion,
								   @Genero,
								   @NumPaginas,
								   @Precio,
								   @Stock) 
			END
         


		CREATE PROCEDURE LibrosGetById
		@IdLibro INT
		AS
			SELECT 
				   Libro.IdLibro,
				   Libro.Titulo,
				   Libro.Editorial,
				   Libro.FechaPublicacion,
				   Libro.Genero,
				   Libro.NumPaginas,
				   Libro.Precio,
				   Libro.Stock
			FROM Libro
			WHERE IdLibro = @IdLibro

         

		CREATE PROCEDURE LibrosUpdate
		@IdLibro INT,
		@Titulo VARCHAR (MAX),
		@Editorial VARCHAR (MAX),
		@FechaPublicacion VARCHAR(20),
		@Genero VARCHAR(20),
		@NumPaginas INT,
		@Precio DECIMAL(10,2),
		@Stock INT
		AS 
			BEGIN
				Update Libro 
				SET Titulo = @Titulo,
					Editorial = @Editorial,
					FechaPublicacion = @FechaPublicacion,
					Genero = @Genero,
					NumPaginas = @NumPaginas,
					Precio = @Precio,
					Stock = @Stock
				WHERE IdLibro = @IdLibro
			END



		CREATE PROCEDURE LibroDelete
		@IdLibro INT
		AS
		BEGIN
			DELETE FROM Libro
			WHERE IdLibro = @IdLibro
		END



         */
    }
}
