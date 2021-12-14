using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        public string Name { get; set; }
        public int EmployerId { get; set; }
        public List<SelectListItem> Employers { get; set; }
        public List<Skill> Skills { get; set; }

        public AddJobViewModel()
        {
        }
        public AddJobViewModel(List<Employer> employerList, List<Skill> skillList)
        {
            Employers = new List<SelectListItem>();
            Skills = new List<Skill>();

            foreach (var employer in employerList)
            {
                Employers.Add(new SelectListItem { Value = employer.Id.ToString(), Text = employer.Name });
            }

            foreach (var skill in skillList)
            {
                Skills.Add(new Skill { Id = skill.Id, Name = skill.Name, Description = skill.Description});
            }

        }
    }
}
