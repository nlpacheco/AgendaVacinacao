using AgendaVacinacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgendaVacinacao.Dalc
{
    public class MockVaccineDatabase
    {
        private List<Models.Vaccine> ListVaccine;

        public MockVaccineDatabase()
        {
            MockVaccines();
            MockFamilyPeople();
        }


        private async void MockFamilyPeople()
        {
            User user = new User()
            {
                Email = "norberto.luciano.pacheco@gmail.com",
                Name = "Norberto",
                FamilyId = Guid.NewGuid()
            };

            await CurrentDataStore.CurrentDALC.GetUserDBProvider.SaveUser(user);

            FamilyPerson person;

            person = new FamilyPerson()
            {
                FamilyId = user.FamilyId,
                Name = "Joao",
                PersonId = Guid.NewGuid(),
                BirthDate= DateTime.Today
            };

            await CurrentDataStore.CurrentDALC.GetFamilyPersonDBProvider.SaveFamilyPerson(person);


            person = new FamilyPerson()
            {
                FamilyId = user.FamilyId,
                Name = "Maria",
                PersonId = Guid.NewGuid(),
                BirthDate = DateTime.Today.AddMonths(-3)
            };

            await CurrentDataStore.CurrentDALC.GetFamilyPersonDBProvider.SaveFamilyPerson(person);



        }



        private void MockVaccines()
        {
            
            var mockVaccine = new List<Vaccine>();
            Vaccine vaccine;

            vaccine = new Vaccine { VaccineId = Guid.NewGuid(), Name = "BGC", Description = "Vacina BCG deve ser aplicada o mais cedo possível" };
            vaccine.VaccineTypes = new List<VaccineType> { new VaccineType { VaccineTypeId = Guid.NewGuid(), VaccineId = vaccine.VaccineId, Description = "BGC", Name = "BCG" } };
            mockVaccine.Add(vaccine);

            vaccine = new Vaccine { VaccineId = Guid.NewGuid(), Name = "BGC", Description = "Vacina BCG deve ser aplicada o mais cedo possível" };
            vaccine.VaccineTypes = new List<VaccineType> { new VaccineType { VaccineTypeId = Guid.NewGuid(), VaccineId = vaccine.VaccineId, Description = "BGC", Name = "BCG" } };
            mockVaccine.Add(vaccine);

            vaccine = new Vaccine { VaccineId = Guid.NewGuid(), Name = "POLIO", Description = "Vacina Polio - Descrição geral" };
            vaccine.VaccineTypes = new List<VaccineType> { new VaccineType { VaccineTypeId = Guid.NewGuid(), VaccineId = vaccine.VaccineId, Description = "VIP Vacina virus inativado injetável", Name = "VIP" },
                                                            new VaccineType { VaccineTypeId = Guid.NewGuid(), VaccineId = vaccine.VaccineId, Description = "VIP Vacina via oral (Gotinha)", Name = "VOP" } };
            mockVaccine.Add(vaccine);

            vaccine = new Vaccine { VaccineId = Guid.NewGuid(), Name = "BGC", Description = "Vacina BCG deve ser aplicada o mais cedo possível" };
            vaccine.VaccineTypes = new List<VaccineType> { new VaccineType { VaccineTypeId = Guid.NewGuid(), VaccineId = vaccine.VaccineId, Description = "BGC", Name = "BCG" } };
            mockVaccine.Add(vaccine);

            vaccine = new Vaccine { VaccineId = Guid.NewGuid(), Name = "BGC", Description = "Vacina BCG deve ser aplicada o mais cedo possível" };
            vaccine.VaccineTypes = new List<VaccineType> { new VaccineType { VaccineTypeId = Guid.NewGuid(), VaccineId = vaccine.VaccineId, Description = "BGC", Name = "BCG" } };
            mockVaccine.Add(vaccine);


            CurrentDataStore.CurrentDALC.GetVaccineDBProvider.SaveAllVaccines(mockVaccine);
        }

    }
}
