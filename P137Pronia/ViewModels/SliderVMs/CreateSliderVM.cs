﻿using System;
using System.ComponentModel.DataAnnotations;

namespace P137Pronia.ViewModels.SliderVMs;

public record CreateSliderVM
{
    [Required, MaxLength(50)]
    public string Title { get; set; }
    [Required, MaxLength(200)]
    public string Desc { get; set; }
    [MaxLength(50)]
    public string? Offer { get; set; }
    [Required, MaxLength(50)]
    public string ButtonText { get; set; }
    [Required ]
    public IFormFile ImageFile { get; set; }
}

