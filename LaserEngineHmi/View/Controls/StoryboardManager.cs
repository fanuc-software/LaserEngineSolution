using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Collections.Generic;

namespace LaserEngineHmi.View.Controls
{
    public class StoryboardManager

    {

        public static DependencyProperty IDProperty =

            DependencyProperty.RegisterAttached("ID", typeof(string), typeof(StoryboardManager),

                    new PropertyMetadata(null, IdChanged));



        static readonly Dictionary<string, Storyboard> Storyboards = new Dictionary<string, Storyboard>();



        public delegate void Callback(object state);



        /// <summary>

        /// IDs the changed.

        /// </summary>

        /// <param name="obj">The obj.</param>

        /// <param name="e">The <see cref="System.Windows.DependencyPropertyChangedEventArgs"/> instance containing the event data.</param>

        private static void IdChanged(DependencyObject obj, DependencyPropertyChangedEventArgs e)

        {

            var sb = obj as Storyboard;

            if (sb == null)

                return;



            var key = e.NewValue as string;

            if (Storyboards.ContainsKey(key))

                Storyboards[key] = sb;

            else

                Storyboards.Add(key, sb);

        }



        /// <summary>

        /// Plays the storyboard.

        /// </summary>

        /// <param name="id">The id.</param>

        /// <param name="callback">The callback.</param>

        /// <param name="state">The state.</param>

        public static void PlayStoryboard(string id, Callback callback, object state)

        {

            if (!Storyboards.ContainsKey(id))

            {

                callback(state);

                return;

            }

            Storyboard sb = Storyboards[id];

            EventHandler handler = null;

            EventHandler handlertemp = handler;

            handler = delegate { sb.Completed -= handlertemp; callback(state); };

            sb.Completed += handler;

            sb.Begin();

        }



        /// <summary>

        /// Sets the ID.

        /// </summary>

        /// <param name="obj">The obj.</param>

        /// <param name="id">The id.</param>

        public static void SetID(DependencyObject obj, string id)

        {

            obj.SetValue(IDProperty, id);

        }



        /// <summary>

        /// Gets the ID.

        /// </summary>

        /// <param name="obj">The obj.</param>

        /// <returns></returns>

        public static string GetID(DependencyObject obj)

        {

            return obj.GetValue(IDProperty) as string;

        }

    }
}
