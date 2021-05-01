using System;
using System.Runtime.CompilerServices;

public class SpaceAge
{
    private readonly float seconds;

    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    /*
    Earth: orbital period 365.25 Earth days, or 31557600 seconds
    Mercury: orbital period 0.2408467 Earth years
    Venus: orbital period 0.61519726 Earth years
    Mars: orbital period 1.8808158 Earth years
    Jupiter: orbital period 11.862615 Earth years
    Saturn: orbital period 29.447498 Earth years
    Uranus: orbital period 84.016846 Earth years
    Neptune: orbital period 164.79132 Earth years
    */

    public double OnEarth()
    {
        return seconds / 31_557_600;
    }

    public double OnMercury()
    {
        return seconds / 31557600 / .2408467;
    }

    public double OnVenus()
    {
        return seconds / 31557600 / .61519726;
    }

    public double OnMars()
    {
        return seconds / 31557600 / 1.8808158;
    }

    public double OnJupiter()
    {
        return seconds / 31557600 / 11.862615;
    }

    public double OnSaturn()
    {
        return seconds / 31557600 / 29.447498;
    }

    public double OnUranus()
    {
        return seconds / 31557600 / 84.016846;
    }

    public double OnNeptune()
    {
        return seconds / 31557600 / 164.79132;
    }
}   
