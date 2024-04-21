﻿namespace WebbApp.ViewModels;

public class CourseViewModel
{
    public int Id { get; set; }
    public bool isBestseller { get; set; }

    public string Image { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Price { get; set; } = null!;

    public string? DiscountPrice { get; set; }

    public string Hours { get; set; } = null!;

    public string LikesInPercent { get; set; } = null!;

    public string LikesInNumbers { get; set; } = null!;
}