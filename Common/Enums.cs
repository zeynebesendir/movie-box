using System;
using System.Collections.Generic;
using System.Text;

namespace MovieBox.Common
{
    public class Enums
    {
        /// <summary>
        /// 
        ///     all	:    Include all movies, TV shows and people in the results as a global trending list.
        ///     movie:   Show the trending movies in the results.
        ///     tv:      Show the trending TV shows in the results.
        ///     person:  Show the trending people in the results.
        ///     
        /// </summary>
        public enum MediaType
        {
            all,
            movie,
            tv,
            person
        }

        /// <summary>
        /// 
        ///      day:    	View the trending list for the day.
        ///      week:      View the trending list for the week.
        /// 
        /// </summary>
        public enum TimeWindow
        {
            Day,
            Week
        }

        public enum ContentGroup
        {
            Streaming,
            TV,
            Rent,
            Theaters
        }
    }
}
