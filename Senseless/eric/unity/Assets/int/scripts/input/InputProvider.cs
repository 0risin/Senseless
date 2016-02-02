using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface IInputProvider
{
    float XAxis { get; }
    float YAxis { get; }
    float Horizontal { get; }
    float Vertical { get; }
    bool Jump { get; }
    bool Use { get; }
    bool Back { get; }
}