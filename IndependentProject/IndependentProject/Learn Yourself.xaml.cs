using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace IndependentProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Learn_Yourself : Page
    {
        public Learn_Yourself()
        {
            this.InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboBoxResultTextBlock != null)
            {
                ComboBox combo = (ComboBox)sender;
                ComboBoxItem item = (ComboBoxItem)combo.SelectedItem;

                if(item.Content.Equals("Mercury"))
                {
                    ComboBoxResultTextBlock.Text = "The smallest planet in our solar system and nearest to the Sun, Mercury is only slightly larger than Earth's Moon. From the surface of Mercury, " +
                        "the Sun would appear more than three times as large as it does when viewed from Earth, and the sunlight would be as much as seven times brighter. Despite its proximity to the Sun, " +
                        "Mercury is not the hottest planet in our solar system – that title belongs to nearby Venus, thanks to its dense atmosphere.";
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/mercury.jpg");
                    credit.Text = "https://solarsystem.nasa.gov/planets/mercury/overview/";
                }
                if (item.Content.Equals("Venus"))
                {
                    ComboBoxResultTextBlock.Text = "Second planet from the Sun and our closest planetary neighbor, Venus is similar in structure and size to Earth, but it is now a very different world. " +
                        "Venus spins slowly in the opposite direction most planets do. Its thick atmosphere traps heat in a runaway greenhouse effect, " +
                        "making it the hottest planet in our solar system—with surface temperatures hot enough to melt lead. Glimpses below the clouds reveal volcanoes and deformed mountains. ";
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/venus.png");
                    credit.Text = "https://solarsystem.nasa.gov/planets/venus/overview/";

                }
                if (item.Content.Equals("Mars"))
                {
                    ComboBoxResultTextBlock.Text = "The fourth planet from the Sun, Mars is a dusty, cold, desert world with a very thin atmosphere. "+
                        "This dynamic planet has seasons, polar ice caps and weather and canyons and extinct volacanoes, evidence of an even more active past. Mars is one of the most explored bodies in our solar system, " +
                        "and it's the only planet where we've sent rovers to roam the alien landscape. NASA currently has three spacecraft in orbit, " +
                        "one rover on the surface and another rover under construction here on Earth. " +
                        "India and ESA also have spacecraft in orbit above the Mars.";
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/mars.jpg");
                    credit.Text = "https://solarsystem.nasa.gov/planets/mars/overview/";

                }
                if (item.Content.Equals("Jupiter"))
                {
                    ComboBoxResultTextBlock.Text = "Fifth in line from the Sun, Jupiter is, by far, the largest planet in the solar system " +
                        "– more than twice as massive as all the other planets combined. "+
                        "Jupiter's familiar stripes and swirls are actually cold, windy clouds of ammonia and water, " +
                        "floating in an atmosphere of hydrogen and helium. Jupiter’s iconic Great Red Spot is a giant storm " +
                        "bigger than Earth that has raged for hundreds of years.";
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/jupiter.jpg");
                    credit.Text = "https://solarsystem.nasa.gov/planets/jupiter/overview/";

                }
                if (item.Content.Equals("Neptune"))
                {
                    ComboBoxResultTextBlock.Text = "Dark, cold and whipped by supersonic winds, ice giant Neptune is the eighth and most distant planet in our solar system. "+
                        "More than 30 times as far from the Sun as Earth, Neptune is the only planet in our solar system not visible to the naked eye and the first predicted by mathematics before its discovery. In 2011 Neptune completed its first 165-year orbit since its discovery in 1846.";
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/neptune.jpg");
                    credit.Text = "https://solarsystem.nasa.gov/planets/neptune/overview/";

                }
                if (item.Content.Equals("Saturn"))
                {
                    ComboBoxResultTextBlock.Text = "Saturn is the sixth planet from the Sun and the second largest planet in our solar system. "
                        + "Adorned with thousands of beautiful ringlets, Saturn is unique among the planets. It is not the only planet to have rings—made of chunks of ice and rock—" +
                        "but none are as spectacular or as complicated as Saturn's. "+ "Like fellow gas giant Jupiter, Saturn is a massive ball made mostly of hydrogen and helium.";
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/saturn.jpg");
                    credit.Text = "https://solarsystem.nasa.gov/planets/saturn/overview/";

                }
                if (item.Content.Equals("Uranus"))
                {
                    ComboBoxResultTextBlock.Text = "The first planet found with the aid of a telescope, " +
                        "Uranus was discovered in 1781 by astronomer William Herschel, although he originally thought it was either a comet or a star. " +
                        "It was two years later that the object was universally accepted as a new planet, " +
                        "in part because of observations by astronomer Johann Elert Bode. " +
                        "Herschel tried unsuccessfully to name his discovery Georgium Sidus after King George III. " +
                        "Instead the planet was named for Uranus, " +
                        "the Greek god of the sky, " +
                        "as suggested by Johann Bode.​";
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/uranus.jpg");
                    credit.Text = "https://solarsystem.nasa.gov/planets/uranus/overview/";

                }
                if (item.Content.Equals("Earth"))
                {
                    ComboBoxResultTextBlock.Text = "Our home planet is the third planet from the Sun, and the only place we know of so far that’s inhabited by living things. "+
                                                   "While Earth is only the fifth largest planet in the solar system, " +
                                                   "it is the only world in our solar system with liquid water on the surface. " +
                                                   "Just slightly larger than nearby Venus, Earth is the biggest of the four planets closest to the Sun," +
                                                   " all of which are made of rock and metal.";
                    bit.UriSource = new Uri(ComboBoxResultImage.BaseUri, "Assets/earth.jpg");
                    credit.Text = "https://solarsystem.nasa.gov/planets/earth/overview/";

                }
            }
        }
        }
    }

