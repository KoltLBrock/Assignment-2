using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_2.Models{
    public class User{
        //id is for database
        [Key]
        public int ID{get;set;}
        [Display(Name = "User Name")]
        public string userName{get;set;}
        [NotMapped]
        public string password{get;set;}
    }
    public class Member : User{
        //student's school id
        [Display(Name="Student ID")]
        public int studentID{get;set;}
        //list of projects student has partaken in
        [NotMapped]
        public List<string> completedProjectListS{get;set;}
        //description of student's skill level
        [Display(Name="Coding Level")]
        public string skillLevel{get;set;}
    }
    public class Professor : User{
        //professor's school ID
        public int profUniqueID{get;set;}
    }
    public class Client : User{
        //list of projects that the client has ready to be sent to the club
        public List<string> readyProjectsList{get;set;}
        //completed projects from this client
        public List<string> completedProjectsListC{get;set;}
        //client trust is description of usefulness of clients projects for learning ability and overall client trust
        public string clientTrust{get;set;}
    }
    public class Project{
        [Key]
        public int ID{get;set;}
        [Display(Name="Project Name")]
        public string projectName{get; set;}
        [Display(Name="Project Description")]
        public string projectDescription{get;set;}
    }
}