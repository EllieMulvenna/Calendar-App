using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Initializes a new instance of the <see cref="Event"/> class."/>
/// </summary>
namespace Calendar_App
{
    /// <summary>
    /// Represents an event with a specified start and end time, title, description, and associated person.
    /// </summary>
    /// <remarks>This class can be used to model events such as meetings, appointments, or other scheduled
    /// activities. It includes properties for the event's time range, title, description, and the person associated
    /// with the event.</remarks>
    public class Event
    {
        /// <summary>
        /// Gets or sets the start date and time of the event.
        /// </summary>
        public DateTime StartDateTime { get; set; }
        
        /// <summary>
        /// Gets or sets the end date and time of the event or operation.
        /// </summary>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the title of the item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the object.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public string Person { get; set; }

        /// <summary>
        /// Returns a string representation of the event, including its title, description, assigned person, and start
        /// and end times.
        /// </summary>
        /// <returns>A string that summarizes the event details, including the title, description, assigned person, and the start
        /// and end times.</returns>
        public override string ToString()
        {
            return "Your event is " + this.Title + ". The description is " + this.Description + " to be done by " + this.Person + ". Starting at " + this.StartDateTime + " and ending at " + this.EndDateTime;
        }
    }
}
