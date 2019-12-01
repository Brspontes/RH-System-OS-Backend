using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Brspontes_RH_System_Domain.CandidateContext.Input
{
    public class CreateAddressCommand : Notifiable
    {
        public CreateAddressCommand(string street, string city, string country, string state, string cep, string publicarea, string district, Guid candidateId)
        {
            this.street = street;
            this.city = city;
            this.country = country;
            this.state = state;
            this.cep = cep;
            this.publicarea = publicarea;
            this.district = district;
            this.candidateId = candidateId;

            AddNotifications(new Contract()
                .IsNullOrEmpty(street, "Address.Street", "Provide street name")
                .IsNullOrEmpty(city, "Address.City", "Provide city name")
                .IsNullOrEmpty(country, "Address.Country", "Provide country name")
                .IsNullOrEmpty(cep, "Address.CEP", "Provide correct CEP"));
        }

        [Required]
        public string street { get; set; }

        [Required]
        public string city { get; set; }

        [Required]
        public string country { get; set; }

        [Required]
        public string state { get; set; }

        [Required]
        public string cep { get; set; }

        public string publicarea { get; set; }

        public string district { get; set; }

        [Required]
        public Guid candidateId { get; set; }
    }
}
