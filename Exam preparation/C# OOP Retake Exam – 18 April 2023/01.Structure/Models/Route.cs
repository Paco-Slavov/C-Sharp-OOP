using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;

namespace EDriveRent.Models;

public class Route : IRoute
{
    private string startPoint;
    private string endPoint;
    private double length;
    private int routeId;
    private bool isLocked;

    public Route(string startPoint, string endPoint, double length, int routeId)
    {
        StartPoint = startPoint;
        EndPoint = endPoint;
        Length = length;
        this.routeId = routeId;
        isLocked = false;
    }

    public string StartPoint
    {
        get => startPoint;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.StartPointNull));
            }
            startPoint = value;
        }
    }
    public string EndPoint
    {
        get => endPoint;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.EndPointNull));
            }
            endPoint = value;
        }
    }
    public double Length
    {
        get => Length;
        private set
        {
            if (value < 1)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RouteLengthLessThanOne));
            }
            Length = value;
        }
    }
    public int RouteId => routeId;

    public bool IsLocked => isLocked;

    public void LockRoute() => isLocked = true;
}
