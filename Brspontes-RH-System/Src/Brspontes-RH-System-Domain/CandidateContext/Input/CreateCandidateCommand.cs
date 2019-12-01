using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Brspontes_RH_System_Domain.CandidateContext.Input
{
    public class CreateCandidateCommand : Notifiable
    {
        public CreateCandidateCommand(string fullname, string curriculum, string email, string observation, string document, CreateAddressCommand address, bool active)
        {
            this.fullname = fullname;
            this.curriculum = curriculum;
            this.email = email;
            this.observation = observation;
            this.document = document;
            this.address = address;
            this.active = active;

            AddNotifications(new Contract().Requires()
                .IsNullOrEmpty(fullname, "Candidate.Name", "please provide full name")
                .IsEmail(email, "Candidate.Email", "Email in incorrect format")
                .IsNullOrEmpty(document, "Candidate.Document", "please provide document"));
        }

        [Required]
        public string fullname { get; set; }

        [Required]
        public string curriculum { get; set; }

        [Required]
        public string email { get; set; }


        public string observation { get; set; }

        [Required]
        public string document { get; set; }

        [Required]
        public CreateAddressCommand address { get; set; }

        [Required]
        public bool active { get; set; }
    }
}
