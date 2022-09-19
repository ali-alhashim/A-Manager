using A_Manager.Models;
using System.Diagnostics;

namespace A_Manager.Data
{
    public class DbInitializer
    {
        public static void Initialize(DatabaseConnectionClass context)
        {
            context.Database.EnsureCreated();

            // Look for any Cars.
            if (context.Cars.Any())
            {
                return;   // DB has been seeded
            }

            // seeds cars
            var Cars = new Car[]
           {
            new Car{serial_number="402034610", vehicle_identification_number="1GNSC8EC8HR508717", brand="شيفورلية", model="سوبربان", plate_number="و ل ق 0444", status="Working", year_of_make=2020},

            new Car{serial_number="402034610", vehicle_identification_number="55FFFGBVD445FG112", brand="Toyota", model="Camry", plate_number="0770 AAA", status="Working", year_of_make=2018},

            new Car{serial_number="958456958", vehicle_identification_number="RF4545ECR4444FDDD", brand="Honda", model="Accord", plate_number="888 REF", status="Working", year_of_make=2009},

           };

            foreach (Car s in Cars)
            {
                context.Cars.Add(s);
            }
            context.SaveChanges();



            // seeds users
            var Users = new User[]
            {
                new User{full_name="Ali Musa Alhashim", email="alhasham@akh.com.sa", is_active=true, is_employee=true, is_superuser=true, job_title="IT Manager", password="********", badge_number="A1"},

                new User{full_name="Yasmin Ali Alyasmin", email="Yasmin@akh.com.sa", is_active=true, is_employee=true, is_superuser=false, job_title="HR Manager", password="********", badge_number="A2"},

                new User{full_name="Mohammed Nasser Alnasser", email="Mohammed@akh.com.sa", is_active=true, is_employee=true, is_superuser=false, job_title="Accounting Manager", password="********", badge_number="A3"},
            };

            foreach (User s in Users)
            {
                context.Users.Add(s);
            }
            context.SaveChanges();



            // seeds Car Driver

            var CarDriver = new Car_Users[]
            {
                new Car_Users{userID=1, user=Users[1], carID=1, car=Cars[0], authorize_start_date=DateTime.Parse("2005-09-01"), authorize_end_date=DateTime.Parse("2005-09-01"), authorize_type="internal", odometer_before="10000", odometer_unit="KM"},
                new Car_Users{userID=2, user=Users[1], carID=1, car=Cars[0], authorize_start_date=DateTime.Parse("2005-09-01"), authorize_end_date=DateTime.Parse("2005-09-01"), authorize_type="internal", odometer_before="85000", odometer_unit="KM"},
                new Car_Users{userID=2, user=Users[1], carID=1, car=Cars[0], authorize_start_date=DateTime.Parse("2005-09-01"), authorize_end_date=DateTime.Parse("2005-09-01"), authorize_type="internal", odometer_before="5000", odometer_unit="KM", odometer_after="90000", status="total loss", note="تم عمل حادث خسارة كليه"},
            };

            foreach (Car_Users s in CarDriver)
            {
                context.Cars_Users.Add(s);
            }
            context.SaveChanges();



        }

        public static void CreateDbIfNotExists(IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<DatabaseConnectionClass>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An error occurred creating the DB.");
                }
            }
        }

    }
}
