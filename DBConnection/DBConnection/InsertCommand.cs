﻿using System;
namespace DBConnection
{
    public class InsertCommand
    {
        public static string Build_3_Tsql_Inserts()
        {

            var guid1 = Guid.NewGuid();
            var guid2 = Guid.NewGuid();
            var guid3 = Guid.NewGuid();
            var guid11 = Guid.NewGuid();
            var guid12 = Guid.NewGuid();
            var guid13 = Guid.NewGuid();
            var message = @"


-- Pokemons
INSERT INTO pokemons
   (ID, NDexId, Name, Legendary, Missable, Type1, Type2)
      VALUES
   ('{0}', '1', 'Bulbasaur', 0, 0, 'Grass', 'Poison'),
   ('{1}', '2', 'Ivysaur',  0, 0, 'Grass', 'Poison'),
   ('{2}', '3', 'Venesaur',  0, 0, 'Grass', 'Poison');

INSERT INTO evolutions
   (ID, EvolutionText)
      VALUES
   ('{0}', 'Evolves at 16 to IvySaur'),
   ('{0}', 'Must be wearing Blue to Evolve'),
   ('{1}', 'Evolves at 4000 Steps');


INSERT INTO notes
   (ID, NoteText)
      VALUES
   ('{0}', 'Found in PalletTown'),
   ('{0}', 'Only in Pokemon Blue'),
   ('{1}', 'Must be caught using Masterball');











INSERT INTO locations
   (ID, Name, Code, Region)
      VALUES
   ('{2}', 'Route 001', 'R.001', 'Kanto'),
   ('{3}', 'Route 020', 'R.020', 'Kanto'),
   ('{4}', 'Route 066', 'R.066', 'Kanto');






INSERT INTO pokemons_locations
   (PokemonID, LocationID)
      VALUES
   ('{0}', '{3}'),
   ('{0}', '{4}'),
   ('{1}', '{3}');

-- The company has these departments.
INSERT INTO tabDepartment
   (DepartmentCode, DepartmentName)
      VALUES
   ('acct', 'Accounting'),
   ('hres', 'Human Resources'),
   ('legl', 'Legal');

-- The company has these employees, each in one department.
INSERT INTO tabEmployee
   (EmployeeName, EmployeeLevel, DepartmentCode)
      VALUES
   ('Alison'  , 19, 'acct'),
   ('Barbara' , 17, 'hres'),
   ('Carol'   , 21, 'acct'),
   ('Deborah' , 24, 'legl'),
   ('Elle'    , 15, null);
";


            return string.Format(message, guid1, guid2, guid3, guid11, guid12, guid13);
        }
    }
}
