﻿namespace GenericRepository.Entities;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Student> Students { get; set; }

}
