﻿namespace Backend.Data.Models;

public class Question
{
    public string QuestionId { get; set; }
    public string QuestionText { get; set; }
    public string Choice_A {get; set;}
    public string Choice_B {get; set;}
    public string Choice_C {get; set;}
    public string Choice_D {get; set;}
    public string Answer { get; set; }
    
    
    //Navigation Property
    public string ExamId { get; set; }
    public Exam Exam { get; set; }
    
}