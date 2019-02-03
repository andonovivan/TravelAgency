namespace TravelAgency.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TravelAgency.Models.TravelAgency;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<TravelAgency.Models.TravelAgency.VacationDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "TravelAgency.Models.TravelAgency.VacationDb";
        }

        protected override void Seed(TravelAgency.Models.TravelAgency.VacationDb context)
        {
            context.Vacations.AddOrUpdate(r => r.City,
                new Vacation
                {
                    City = "Paris",
                    Country = "France",
                    Continent = "Europe",
                    ShortDescription = "Every day, the magnetic City of Light draws visitors who travel from around the globe to see iconic attractions like the Eiffel Tower, the Louvre and Notre Dame in real life. But what travelers really fall in love with are the city's quaint cafes, vibrant markets, trendy shopping districts and unmistakable je ne sais quoi charm.",
                    LongDescription = "The City of Light draws millions of visitors every year with its unforgettable ambiance. Of course, the divine cuisine and vast art collections deserve some of the credit as well. The gentle River Seine rambles through the city, flanked by stately museums, centuries-old churches, and blocks of Rococo- and Neoclassic-design architecture, further enhanced by cascading trees and glowing streetlamps. Peppering the Seine's cobbled walks and graceful bridges are impossibly chic Parisians, probably on their way to the market, cafe or cinema. Containing world-class museums, fashion, cuisine and an atmosphere all its own, Paris is also a city of 'many splendors,' as Ernest Hemingway recalled in his memoir, 'A Moveable Feast.' Visit the beloved Musée d'Orsay, shop the biggest designers on the Champs Élysées or hit the boutiques in Le Marais, take in the view atop the Eiffel Tower, or even plan a day trip to Versailles Palace. But don't miss out on the simple pleasure of meandering the marvelous arrondssements (districts), or snacking on street crepes either.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/86/gettyimages-615356742.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1782567/pexels-photo-1782567.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                },
                new Vacation
                {
                    City = "Yellowstone",
                    Country = "USA",
                    Continent = "North America",
                    ShortDescription = "Considered by many to be a rite of passage for any American, a visit to Yellowstone will leave you in awe of nature's power. Marvel at the kaleidoscopic waters of the Grand Prismatic Spring, catch the hourly show put on by Old Faithful, hike along the Grand Canyon of the Yellowstone or simply relax with a picnic at Yellowstone Lake.",
                    LongDescription = "With dramatic peaks and pristine lakes, Yellowstone National Park is an outdoor enthusiast's paradise. Multicolored pools swirl around hot springs; verdant forests weave past expansive meadows; and volatile geysers launch streams of steaming water toward the sky. With so much unspoiled natural beauty, it's no wonder why everyone suspected John Colter (a scout for explorers Lewis and Clark) was embellishing when he first described Yellowstone's geothermal curiosities in 1807. Nowadays, there's no doubt that the park is indeed extraordinary. While you traverse its 3,000-plus square miles of mountains, canyons, geysers and waterfalls, be prepared to share the trails with permanent residents like buffalo, elk and sometimes even grizzlies. Although Yellowstone attracts more than 4 million visitors every year, chances are – unless you spend your entire trip at Old Faithful – you won't see much of them. Yellowstone's 2.2 million acres creep from the northwest corner of Wyoming into the edges of Idaho and Montana, offering plenty of untouched territory to explore.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/7/yellowstone-main-getty-2016.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/534371/pexels-photo-534371.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Rome",
                    Country = "Italy",
                    Continent = "Europe",
                    ShortDescription = "When you visit the Eternal City, prepare to cross a few must-see attractions – the Colosseum, the Trevi Fountain and the Pantheon, to name a few – off your bucket list. Additional treasures like St. Peter's Basilica and the Sistine Chapel can be found in nearby Vatican City. Escape the tourist crowds with a twilight stroll through the cobblestone streets of Trastevere.",
                    LongDescription = "Rome, the city of seven hills, enjoyed a mythic beginning. Romulus and Remus – twin brothers who were nursed by a she-wolf and fathered by a war god – reportedly founded the Eternal City. And although historians are a little skeptical about this epic entry into the world, most travelers are absolutely certain that there is something magical about Rome. Whether it's the mystery of nearby Vatican City or the ghosts of the Colosseum, an afternoon caffè on Piazza Navona or a piled-high plate of pasta at a trattoria, Roma is sure to enchant. Italy's capital city, Rome is also known for a history that dates back to the eras of Octavian, Julius Caesar and Hadrian, among others. Left behind are structures like the Pantheon, the Roman Forum and dozens of churches, among other historic gems. Art enthusiasts will relish the trove of art housed at the Vatican Museums, and foodies will enjoy the splendid Italian fare, not to mention the gelato. And though its momentous past is the focus for many vacationers, Rome is also a fast-paced, modern and relevant city, with gleaming designer storefronts, sleek hotels and cutting-edge restaurants.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/108/gettyimages-525777231.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1797161/pexels-photo-1797161.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "London",
                    Country = "England",
                    Continent = "Europe",
                    ShortDescription = "London is a world unto itself. The eclectic neighborhoods, which house a blend of historic landmarks and modern-day attractions, can keep you occupied for days. If it's your first time, don't pass up a visit to the Tower of London, Buckingham Palace or the British Museum before sitting down to a classic afternoon tea.",
                    LongDescription = "The English writer Samuel Johnson famously said, 'You find no man, at all intellectual, who is willing to leave London.No, Sir, when a man is tired of London, he is tired of life; for there is in London all that life can afford.' More than two centuries have passed since Johnson's era, but his words still ring true. Life in London is nothing short of invigorating, and travelers find that one visit isn't enough to experience everything this two-millennia-old city has to offer. Here, the antiquated clasps hands with the contemporary. You'll find the historic Tower of London and the avant-garde Tate Modern both considered must-sees. Shakespeare's sonnets are still being uttered by actors who don modern garb. Londoners most certainly still respect the royals, but they also jam to the likes of Arctic Monkeys and Adele. And while they still praise the power of tea, they now make room for some Starbucks here and there, and pressed juice too. A current leader in everything from politics and banking to fashion and music, London's culture compass is always attuned to what's next.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/82/gettyimages-482151882.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/374815/pexels-photo-374815.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Phuket",
                    Country = "Thailand",
                    Continent = "Asia",
                    ShortDescription = "Located in southern Thailand, Phuket offers something for everyone, especially budget-minded travelers. Everything from accommodations to spa treatments and boat tours come with a low price tag. For stunning scenery, check out the limestone cliffs of Phang Nga Bay and the beaches of the Phi Phi Islands. Other must-sees include Wat Chalong Temple and the Big Buddha.",
                    LongDescription = "Pure white sands, aquamarine waters and limestone cliffs await travelers who visit Thailand's southwestern island of Phuket. Surrounded by the Andaman Sea and about an hour by plane from Bangkok, this island is a little piece of paradise, which comes with a relatively low price tag for everything from its accommodations to spa treatments and boat tours. But along with its tropical appeal, Phuket beckons to travelers wanting to experience its flavorful cuisine (think: lemongrass, lime leaves, chillies) and its rich culture, heavily influenced by its reigning religion: Buddhism. And although the island's beaches and tourism operators have bounced back from the 2004 tsunami, which hammered its western coast and tragically claimed thousands of lives, it remembers the past with memorials and a better warning system, should the area once again come under threat.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/364/main_image_2017_getty.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/459252/pexels-photo-459252.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Grand Canyon",
                    Country = "USA",
                    Continent = "North America",
                    ShortDescription = "Measuring roughly 277 river miles long and 18 miles wide, the Grand Canyon offers plenty of outdoor activities for adventure junkies. Hike along the popular Rim and Bright Angel trails for unparalleled views of the rust-colored landscape, or cool off with a whitewater rafting excursion down the Colorado River.",
                    LongDescription = "'Grand' doesn't begin to do this canyon justice. Measuring approximately 277 river miles in length, up to 18 miles in width and a mile deep, this massive chasm in northern Arizona is truly a natural wonder. For six million years, the Grand Canyon has expanded with the help of the mighty Colorado River, and for centuries, people from all over the globe have traveled to gaze out over its red and orange grandeur. Managed by the National Park Service and officially designated as a UNESCO World Heritage site, the Grand Canyon leaves its approximately 6 million visitors per year awestruck. But if you're seeking a secluded escape to Mother Nature, you should be prepared: The Grand Canyon can be very crowded. The South Rim – home to the Grand Canyon Village and the well-worn Bright Angel Trail – is particularly popular for sightseers and hikers. It is on this side that you'll find the most amenities. For a break from the crowds, head to the North Rim. This is the place for backwoods camping and hardcore hiking.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/16/grand_canyon_main_2014_-_shutterstock-kojihirano.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1672813/pexels-photo-1672813.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Dubai",
                    Country = "UAE",
                    Continent = "Asia",
                    ShortDescription = "Stunning Persian Gulf views, heart-pumping activities and historic landmarks await in Dubai. This Middle Eastern city is filled with one-of-a-kind attractions, including the Burj Khalifa, the Dubai Mall, and the indoor Ski Dubai. But the city still holds onto its heritage, as seen in the Bastakiya Quarter and traditional gold and spice souks.",
                    LongDescription = "Dubai and Las Vegas have a lot in common. Both cities share a love for the fantastical, with skylines that shine like beacons against barren desert backdrops. People from all over the world flock to these shimmering oases with the same goal: to play hard. But as a vacation spot, Dubai easily trumps ol' Sin City thanks to its gorgeous cream-colored Persian Gulf shoreline, international culinary scene and larger-than-life attractions. And the city's still growing; plans are underway for something bigger and better. At one point, it was estimated that a quarter of the world's construction cranes could be found here. If that's any sign, even the sky may not be able to limit Dubai's growth. Dubai is a city of superlatives, home to the world's tallest tower, one of the world's largest shopping malls, and one of the world's largest man-made marinas… but on a smaller scale, this emirate is still tied to its days as a modest port town. Traditional wooden abras (boats) float past motorboats on Dubai Creek, the natural sands of Jumeirah Beach fringe the carefully sculpted Palm Islands, and the bustling Gold and Spice Souks (marketplaces) thrive amid the larger-than-life Dubai Mall. Despite constantly looking to the future, this city isn't quick to let go of its past. It's this dynamic that not only put Dubai on the tourist map but will also keep it there.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/305/183346577.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/823696/pexels-photo-823696.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "New York City",
                    Country = "USA",
                    Continent = "North America",
                    ShortDescription = "New York City hosts infinite urban adventures: You can wander through Central Park, tour the exhibits at the Met, catch a Broadway show or peruse SoHo's stylish boutiques. And at night, admire Manhattan's glittering skyscrapers from the top of the Empire State Building or the rooftop bar of your trendy boutique hotel.",
                    LongDescription = "Cool, cosmopolitan, crowded, constantly evolving … the Big Apple blends big city splendor with small-town charm. Amid Gotham's iconic landmarks and towering skyscrapers, you'll experience a vibrant culture permeating each of the city's distinctive neighborhoods and boroughs. Follow trendsetters to the East Village and Brooklyn to check out indie boutiques, iconic bakeries and trendy coffee shops. Afterward, peruse the racks of the sleek shops lining Fifth Avenue, admire the cutting-edge art collections at the MoMa and the Met, catch a memorable show on Broadway or sit down for a meal at the latest 'it' restaurant. As the most populous city in the U.S. – set at the forefront of food, fashion and the arts – NYC requires stamina. But don't let the Big Apple's frenetic sights and sounds intimidate you from soaking up its grandeur. Wander through the concrete jungle and you'll discover roaring taxis zipping down bustling blocks, fast-paced pedestrians strolling past on their way to marquee galleries and trendy cocktail bars, and Times Square's neon lights flickering at all hours. And yet, the city's twinkling lights and chaotic corners also invite you to embrace every New York minute, explore every enclave and create your own urban adventure. There are endless ways to spend your time in the city that never sleeps, but before you leave, stop and look around – what's here today will be transformed into something bigger and better tomorrow.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/44/main_image_september_2013.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/374710/pexels-photo-374710.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Argentine Patagonia",
                    Country = "Argentina",
                    Continent = "South America",
                    ShortDescription = "If you consider yourself an adventurous traveler, you've found your match in Argentine Patagonia. Otherworldly landscapes await you in Southern Patagonia, while endangered species (think: Magellanic penguins) roam Peninsula Valdés – a UNESCO World Heritage site. Another must-see: Perito Moreno, one of the only glaciers in the world that is growing, not shrinking.",
                    LongDescription = "This region in the Andes mountains is nothing if not enchanting. Cobalt lakes, azure-tinted glaciers, emerald trees, and turquoise skies stretch as far as the eye can see. In fact, Argentine Patagonia's vistas are so sweeping that Charles Darwin once described the region as 'boundless.' Visit Argentina's Lake District and you'll discover villages brushing against snowy mountain peaks. Travel east and you'll find whales gliding through Peninsula Valdés' marine wildlife sanctuary. Venture to Southern Patagonia, and you'll stumble upon deserts extending into rugged estancias (cattle-ranges) and melting glaciers. And, if you continue downward to the Chilean border at Cape Horn, you'll come across an expansive horizon reaching out to Antarctica's frosty edge. Patagonia's beauty knows no bounds. But don't let the frontier's vastness fool you: Argentine Patagonia's rapidly developing infrastructure grants visitors easy access to all major attractions. Rustic roads lead to dramatic natural wonders like Perito Moreno Glacier and Mount Fitz Roy. Look around this beautiful landscape and discover a region buzzing with life. Magellanic penguins and albatross mingle in the Punta Tombo wildlife reserve, while history survives on the walls of the Cave of the Hands.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/319/main_image.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1684166/pexels-photo-1684166.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Barcelona",
                    Country = "Spain",
                    Continent = "Europe",
                    ShortDescription = "This city is a feast for the eyes: Visitors can walk past medieval architecture in the Barri Gòtic, snap photos of the intricate La Sagrada Família and marvel at Gaudí's whimsical creations in Güell Park. Meanwhile, Las Ramblas buzzes at all hours while La Barceloneta Beach is the perfect place to pass the time on a hot day.",
                    LongDescription = "Barcelona contains both the authentically historic and the wildly bizarre. From the scenic trails of the colorful Park Güell to the romantic narrow alleys of Barri Gòtic; from the beachside nightclubs to the city's dozens of sacred churches and architectural marvels, this city by the sea seems to attract all types: the adventurer, the couple, the partier, the culture lover – and more – with an almost overwhelming variety of things to do. You could stay for a few days, but chances are you'll need a whole week to explore. In Barcelona, even the beach is bustling, but it's really the cosmopolitan city that gets all the attention. Much of the activity revolves around Las Ramblas, a series of narrow streets and alleys packed with restaurants, nightclubs and a vibrant pedestrian market. But you should also take a tour of Antoni Gaudí's masterpieces; Gaudí is responsible for sites like Casa Milà, Casa Batlló and La Sagrada Familia. You also shouldn't miss out on the eclectic shopping scene and the region's exquisite food and wine. You see why we suggest a week vacation?",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/97/gettyimages-485934518.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1388030/pexels-photo-1388030.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Yosemite",
                    Country = "USA",
                    Continent = "North America",
                    ShortDescription = "Year after year, millions travel to Yosemite National Park to stand in awe of natural wonders like Glacier Point and the Tunnel View Outlook. Hit the hiking trails early in the day to avoid crowds looking for the perfect photo op. To save some serious coin, skip the hotel and camp out for the full experience (just be sure to book your spot well in advance).",
                    LongDescription = "One of California's most formidable natural landscapes, Yosemite National Park features nearly 1,200 square miles of sheer awe: towering waterfalls, millennia-old Sequoia trees, striking, daunting cliff faces and some of the most unique rock formations in the United States. But despite its enormous size, most of the tourist activity takes place within the 8-square-mile area of Yosemite Valley. Here you'll find the park's most famous landmarks – Half Dome and El Capitan – as well as excellent hiking trails through the natural monuments. Even inexperienced hikers can enjoy Yosemite: Guided tours and climbing lessons are available from local adventure outfitters. Just don't expect to experience it by yourself. Like so many other American tourist destinations, crowds are the biggest obstacles to an enjoyable Yosemite vacation – approximately 4 million people visit each year. But if you go at the right time (and start your day a little earlier than usual), Mother Nature's wonders will reveal themselves to you in a miraculous and serene way.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/94/gettyimages-599456588.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/36363/pexels-photo.jpg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Santorini",
                    Country = "Greece",
                    Continent = "Europe",
                    ShortDescription = "Frequently touted as a top honeymoon destination, this Greek isle woos newlyweds every year with its breathtaking sunsets, pastel-hued villages and colorful beaches. Archaeological sites, such as Ancient Thira and Ancient Akrotiri, beckon to history buffs, while central Santorini's winery tours lure oenophiles. For a relaxing daytrip, hop on a boat to Thirassia.",
                    LongDescription = "A massive volcanic eruption around 1650 B.C. forced the center of what was then a single island to implode and succumb to the sea. Some say that this was the original home of the lost city of Atlantis, which long ago disappeared into the ocean's depths. Whatever remains of this mythological metropolis is now guarded by beautiful beaches and stately whitewashed homes. Today, Santorini consists of two inhabited islands and several islets. Most visitors spend their time on Thira (the archipelago's largest island), which is home to Santorini's major towns, including Fira and Oia. Sleepy Thirassia makes for a relaxing daytrip too. And don't count out the quieter islands: Nea Kameni and Palea Kameni are worth exploring. Your first order of business in Santorini is to hit the colorful beaches – the black and red sands make for a memorable visit. Next up, indulge in the archaeological delights of the impressively preserved Ancient Akrotiri or hike to Ancient Thera to see the ruins of three empires, including the Romans. From there, catch a breathtaking view of the caldera, a brilliant turquoise pool of water that serves as the nucleus for the varied isles of this archipelago. Some would say you only need a day to enjoy these islands' charms (they are a popular port of call for cruise ships), but to really drink in all Santorini has to offer, you'll need a few days to a week. Then you'll have plenty of time to learn there's more to these comely dots of the Cyclades than meets the eye.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/73/gettyimages-462922955.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1285625/pexels-photo-1285625.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Maui",
                    Country = "USA",
                    Continent = "North America",
                    ShortDescription = "Whether you're driving along the Road to Hana, enjoying a bird's-eye view of the lush coastline from a helicopter or simply relaxing on the island's honey-colored beaches, you'll find that Maui is unlike any other tropical destination. Don't miss a chance to visit Haleakala National Park, home to the world's largest dormant volcano.",
                    LongDescription = "Maui is not nearly as large as the Big Island, nor is it as small as Lanai, as bustling as Oahu or as quiet as Kauai. For many Hawaii vacationers, Maui is just right – offering a taste of just about everything the Aloha State has to offer, from impressive wildlife to intriguing history and culture. While on a visit here, you can shimmy alongside professional hula dancers, golf along coastal fairways, snorkel alongside five different types of sea turtles or simply lounge along some of Hawaii's most notable beaches. One of the archipelago's most popular tourism spots, Maui can be found sandwiched between the Big Island and the much tinier Molokai. Maui is divided into five distinct regions: Many travelers base themselves along the coasts of South Maui (home to the famous Wailea Beach) or West Maui, where the sands of Kaanapali Beach and the music from the Old Lahaina Luau are located. But the rest of the island should not be missed. Travel along the Road to Hana to experience East Maui's scenic coastline, explore Haleakala – the world's largest dormant volcano – in the Upcountry and explore the former tribal battlegrounds of Central Maui's Iao Valley State Park.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/61/2016-main-getty.jpg",
                    ImageUrlDetailed = "http://miriadna.com/desctopwalls/images/max/Hawaiis-Maui-(Usa).jpg"
                },
                new Vacation
                {
                    City = "Sydney",
                    Country = "Australia",
                    Continent = "Australia",
                    ShortDescription = "This metropolis offers more than just a dizzying array of landmarks (e.g., the Sydney Opera House, Sydney Harbour and the Sydney Harbour Bridge). The Australian city boasts a warm, sunny climate ideal for enjoying Sydney's long list of seasonal festival and events, not to mention its local beaches like Coogee, Bondi and Manly.",
                    LongDescription = "Sydney is both a laid-back beachside town and a thriving metropolis that boasts some of the Southern Hemisphere's best surf, landmarks and activities. Whether you're looking to watch a show at the iconic Opera House, take to the waves at Bondi Beach or explore trendy areas like The Rocks and Darling Harbour, Sydney features something for everyone. Even Sydneysiders have an ideal mix of both worlds: Fashion-forward attire and British-style sarcasm combine with a 'no worries' attitude and relaxed coastal vibe. It's no wonder this vibrant city down under is a natural choice for first-time Aussie visitors. In addition to tons of beaches and top-notch restaurants and bars, Australia's most populous city features an array of things to do. Thrill-seekers can participate in heart-pounding activities like a Sydney Harbour Bridge climb, while visitors looking to unwind will appreciate a relaxing day at Coogee or Manly Beach or a peaceful stroll through the Royal Botanic Garden. There's also plenty of seasonal Sydney festivals and events to experience, such as Sculpture by the Sea, the Festival of the Winds and the Night Noodle Markets. Whether you're looking to enjoy a rugby match, hit up the city's museums or lounge on a beach, Sydney's got you covered.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/290/sydney_opera_house_new_main.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/783683/pexels-photo-783683.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Hong Kong",
                    Country = "China",
                    Continent = "Asia",
                    ShortDescription = "Hong Kong is a study in contrasts. Alongside its towering skyscrapers and frenzied street markets, there's the peaceful Nan Lian Garden and the scenic Tsim Sha Tsui Promenade. For a mix of both, hop a ferry to Lantau Island, home to a Buddhist monastery, Hong Kong's longest beach and the territory's Disneyland outpost.",
                    LongDescription = "To outsiders, Hong Kong can raise a lot of questions: 'Is it part of China or not ? ' 'Is it one island or two ? ' 'Do they speak English or Mandarin ? Or both ? ' And foreigners have a good reason to ask them. This territory, made of multiple islands, returned to China's possession in 1997 after more than a hundred years of British occupation. Upon its reunification with China, Hong Kong added certain stipulations that provide a unique degree of autonomy. For instance, the official currency remains the Hong Kong dollar (HKD); English and Chinese are the official languages; and the tiny nation has an independent judiciary system. In short, China and Hong Kong observe a 'one country, two systems' policy that can have many foreigners scratching their heads. But don't question it. Just accept it and enjoy everything this territory has to offer. Hong Kong distinguishes itself from its Chinese brethren like Shanghai and Beijing with its vibrant, multifaceted culture and stunning cityscape. This British-Chinese hybrid astounds visitors with its striking juxtaposition of dense skyscrapers and lush landscapes. From sandy beaches to rugby pitches, there's more fresh air than most travelers suspect. And, of course, as a world-class metropolis, Hong Kong boasts numerous urban diversions, such as culinary hot spots and museums. After visiting Hong Kong, the only question you might be asking is: 'Why didn't I get here sooner?'",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/282/486878520.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1455964/pexels-photo-1455964.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Rio de Janeiro",
                    Country = "Brazil",
                    Continent = "South America",
                    ShortDescription = "Christ the Redeemer and the shores of Copacabana and Ipanema provide reason enough to plan a trip to Rio, but there's much more to the Marvelous City than scenic vistas, tropical rainforests and cerulean seas. Revel in the sounds of samba in the Lapa neighborhood after strolling along the cobblestone streets of Santa Teresa.",
                    LongDescription = "Known as the Cidade Maravilhosa (Marvelous City), this glimmering Brazilian metropolis has certainly earned its title. Resting at the mouth of a bay harbor, the city is lined with white-sand beaches, lush rainforests and surrounded by staggered green mountains. Rio de Janeiro boasts dramatic views from nearly every angle. From the slopes of Corcovado Mountain, you'll admire the striking 125-foot-tall Christ the Redeemer, who overlooks Rio's pristine beaches. And from the shores of Copacabana and Ipanema, you'll admire the picture-perfect backdrop that has attracted Cariocas (native Brazilians born in Rio de Janeiro) and visitors alike for more than 500 years. But there's much more to Rio than scenic vistas, tropical rainforests and cerulean seas. Here, glitz, high fashion and a laid-back attitude dominate the city's character. Stroll along Avenida Atlântica in Copa, and you'll find a city brimming with bikini-clad beachgoers. The city is also known for its love of sport. From Maracana Stadium (home of the 2014 World Cup finals and the 2016 Olympic Games) to the volleyball courts of Flamengo Park, the city is alive with activity. At night, you'll hear the soothing sounds of samba pulsating through the city streets in Lapa. And if you visit in February — just in time for Carnival — you'll witness Brazil's vibrant Portuguese masquerade that draws revelers from across the globe.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/315/main.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/811212/pexels-photo-811212.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Florence",
                    Country = "Italy",
                    Continent = "Europe",
                    ShortDescription = "The historic city of Florence offers plenty of world-famous attractions, including the Duomo, Piazzale Michelangelo and Piazza della Signoria. After appreciating the city's Renaissance architecture and art, sample some of the region's delectable Tuscan food and wine at the city's quaint cafes, gelato shops and ristorantes.",
                    LongDescription = "This little city, tucked amid the Tuscan hills, casts a long shadow through history. The wellspring of the Renaissance, Firenze (or Florence) sheltered the powerful Medici family and inspired artists like Michelangelo (David) and Brunelleschi (the Duomo). If it weren't for the fashionable Italians and chic shops lining Via Tornabuoni, you might think you had traveled back in time to the 14th century. But Renaissance art is not the only reason to come: You also visit Florence for its gorgeous sunsets, its Italian cooking and its unbeatable romantic charm.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/95/main-2016-getty.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/161376/firenze-florence-italy-europe-161376.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "British Virgin Islands",
                    Country = "British Virgin Islands",
                    Continent = "Caribbean",
                    ShortDescription = "If picturesque beaches and warm weather are what you're after, look no further than the British Virgin Islands. For easy access to Smuggler's Cove, Brewers Bay and other top-notch BVI beaches, consider booking your hotel room on Tortola, the area's largest island. Plus, you can easily hop between the smaller islands on a boat tour.",
                    LongDescription = "The British Virgin Islands, or BVI for short, are some of the most exclusive and least developed islands of the Caribbean, but this only adds to their appeal. The resorts, villas, restaurants and other tourist attractions in this paradise are known to emphasize spare luxury over sprawling expansion, and they attract travelers with deep pockets and a love for sailing and seclusion. Many travelers who visit come by ferry boat from another Caribbean isle, especially as some find opulent exile too hard to enjoy for longer than a day or two. And some say it's better to split your time between here, the nearby U.S. Virgin Islands and Anguilla to the east. Others find more than enough to keep them exclusively anchored by these 60 islands and cays, which sadly were hit hard by Hurricane Irma in September 2017. Travelers will still be able to find evidence of the hurricane's handiwork, though BVI has done a valiant job of rebuilding. On Tortola, you'll find mountainous cliffs and chalk white beaches, characterized by changing tides and calm easterly winds. A brief sail away, sleepy Jost Van Dyke offers delicious Caribbean food and drink, one of the region's best New Year's Eve parties, as well as a few outdoor excursions like diving and fishing. On Virgin Gorda, you'll find The Baths, perhaps the most picturesque shore in the British Virgin Islands, and with good reason: It offers unique grottoes amidst gigantic granite boulders (just be mindful of the daytripping crowds). For supreme seclusion, try Anegada; its slow pace, flat terrain and sparkling sand lies almost overlooked in Caribbean Sea.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/74/bvi_new_main_edited.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/853199/pexels-photo-853199.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Costa Rica",
                    Country = "Costa Rica",
                    Continent = "Central America",
                    ShortDescription = "From volcanic mountains to verdant rainforests to stunning shorelines, Costa Rica is one of the best kept secrets in Central America – but not for long. Explore the beaches along the Nicoya Peninsula before heading to the remote Tortuguero National Park to spot exotic wildlife. Just make sure you plan a visit during the country's dry season (mid-December to April).",
                    LongDescription = "To many, Costa Rica's charm lies in its lush rainforests, unspoiled beaches and abundance of wildlife. With breathtaking landscapes and a myriad of creatures – from toucans to monkeys to jaguars – it's easy to see why. Where else can you hike active volcanoes, zip line through cloud-covered rainforests and surf warm turquoise waters within the span of just a few days? In this compact but diverse tropical paradise, exhilarating outdoor activities are abundant. Nature-seekers will roam thick jungles while beachgoers will sprawl across the powdery sands. It's hard not to admire all the splendors this 'Rich Coast' has to offer. However, for others, this small Latin American country has a different appeal: it's a relaxed way of life. Residents – known as Ticos – often recite the catchphrase 'pura vida' (or 'pure life'). This guiding philosophy can be observed from Costa Rica's central cosmopolitan capital of San José all the way to the sandy Atlantic and Pacific coasts. To truly immerse yourself in the good life, kick back and admire the awe-inspiring scenery. Surround yourself with graceful butterflies at La Paz Waterfall Gardens, hike along the monumental Arenal Volcano, mingle with locals at Puerto Viejo de Talamanca, or simply sit in a hammock under a palm tree along the Nicoya Peninsula. We have a strong feeling you'll discover the pure life, too.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/316/exploring_1_-_tortuguero_national_park.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1624880/pexels-photo-1624880.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "Bali",
                    Country = "Indonesia",
                    Continent = "Asia",
                    ShortDescription = "Serene temples and beautiful beaches are the biggest draws to this lush paradise. And we do mean lush – the region's notoriously soggy wet season is best avoided by planning a visit between April and October. Break up your beach time with a visit to Kintamani, home to a towering (and active) volcano and a large lake.",
                    LongDescription = "Shangri-La, Elysium, Arcadia, Utopia and Bali are all synonymous with 'heaven.' The only difference between them is that you can actually visit Bali. Many travelers have never been to this Indonesian island. Yet, the word 'Bali' conjures daydreams of the most fantastical landscape: towering volcanoes wrapped in a deep green canopy, sandy shores that fade into turquoise waters and curving coastlines crowned with staggered pagodas. And believe it or not, Bali rarely disappoints. You'll be amazed at how many different types of visitors revel in this paradise. The ordinary traveler simply stays at the palatial oceanfront resort and indulges in luxurious spa treatments, decadent cuisine and lazy sunbathing. But the historian will find his or her delights at the island's many temples while the adventurer will discover new paths up an active volcano in Kintamani. Plus, the town of Kuta boasts more riotous pleasures for those inclined to late nights. Bali is a dream come true, so wake up and book your ticket.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/279/nusa_dua_chairs_getty_zsolt_hlinka.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/1477310/pexels-photo-1477310.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "St. Lucia",
                    Country = "St. Lucia",
                    Continent = "Caribbean",
                    ShortDescription = "Dotted with luxurious boutique hotels, this Caribbean destination is tailor-made for lovebirds and adrenaline junkies. Those in search of relaxation will find it on the island's unspoiled shorelines (specifically Reduit and Anse Chastanet), while adventure seekers test their limits climbing the Pitons or zip lining through the Chassin region's rainforest.",
                    LongDescription = "Lush, unspoiled St. Lucia has a growing fan base. Some of its vacationers are music lovers, letting loose at the springtime St. Lucia Jazz & Arts Festival, or adrenaline junkies, testing their limits climbing The Pitons or zip lining through the Chassin region's rain forest. Others are honeymooners, unwinding on one of the island's chalky beaches or holing up in one of its isolated resorts. But what if you don't fall into any of these categories? Don't worry: St. Lucia refuses to be pigeonholed as any 'type' of Caribbean vacation. Plus, you also don't have to spend a lot of money (its reputation as a luxurious hideout is only somewhat warranted). To discover some of the island's indescribable charms, you'll have to visit for yourself. Start your mornings basking in an orange-tinted Soufrière sunrise then round out your evenings at an evening 'jump - up' (or dance party) along Gros Islet.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/233/gettyimages-157529012.jpg",
                    ImageUrlDetailed = "http://stluciastatic.com/simpleview/image/upload/crm/saintlucia/1.Beach-from-South-End1-4d087c235056b3a_4d088008-5056-b3a8-499ee62a03fd28a3.jpg"
                },
                new Vacation
                {
                    City = "Prague",
                    Country = "Czech Republic",
                    Continent = "Europe",
                    ShortDescription = "With its Gothic, Renaissance and Baroque architecture adorning top attractions like Old Town Square, Prague Castle, St. Vitus Cathedral and the Prague Astronomical Clock, Prague makes travelers feel like they're in a fairy tale. Make sure to visit the popular Charles Bridge and touch one of the 30 saint statues for luck.",
                    LongDescription = "A prosperous and bustling city, Prague now attracts more tourists than ever. But its picturesque downtown veils both a dark legacy and a resilient past. Dating back to about A.D. 870, Prague has withstood numerous overthrows, invasions, fires and floods. It's this reputation for survival and perseverance that has made the Czech capital so fascinating. Today, its storied churches, narrow streets, daunting hilltop castle and statue-lined bridges create the scene of an urban fairy tale. Even the most jaded traveler would have trouble resisting this city's charms. Prague was once a hidden gem, overshadowed by its flashier neighbors to the west. But the city couldn't keep its marvels a secret for too long – now, it's a haven for travelers seeking awe-inspiring experiences at affordable prices. Even today, top attractions – including the famous Charles Bridge and the historic Prague Castle – offer free admission and many hotels offer rooms at a fraction of the cost of other European cities. But this bargain-hunting legacy has a ticking clock on it, so if you're hoping to find a fire-sale price, now's the time to do so.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/103/gettyimages-142761840.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/161077/prague-vencel-square-czech-republic-church-161077.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                },
                new Vacation
                {
                    City = "San Francisco",
                    Country = "USA",
                    Continent = "North America",
                    ShortDescription = "Home to some of America's most recognizable landmarks, including the Golden Gate Bridge, Fisherman's Wharf and Alcatraz Island, San Francisco has the ability to satisfy outdoorsy types, foodies and curious wanderers of all ages. If you don't have time to hit all the top spots, a scenic ride on one of the city's historic cable cars is a must.",
                    LongDescription = "A jumbled collage of colorful neighborhoods and beautiful views, San Francisco draws those free-spirited types who have an eye for edgy art, a taste for imaginative cuisine and a zeal for adventure. It's really not surprising that songwriter Tony Bennett left his heart here: The city boasts jaw-dropping sights, world-class cuisine, cozy cafes and plenty of booming nightlife venues – there's no shortage of ways to stay busy here. Spend an hour or two sunning yourself alongside sea lions on the bay, admiring the views of the city from Twin Peaks, or strolling along the Marina. And for the quintessential San Franciscan experience, enjoy a ride on a cable car. Often described as Los Angeles' more refined northern cousin, cool and compact San Francisco takes the big-city buzz exuded by its southern counterpart and melds it with a sense of small-town charm. Here, you'll discover a patchwork of culture flourishing throughout San Francisco's many vibrant quarters. Follow the crowds to the touristy Fisherman's Wharf area (which offers spectacular views of Alcatraz) before heading along the bay to the Presidio for a glimpse of the famous Golden Gate Bridge. But don't forget to save time for the Mission District, the Haight and the Castro for exposure to all of the different varieties of the San Francisco lifestyle.",
                    ImageUrl = "https://travel.usnews.com/static-travel/images/destinations/20/gettyimages-123318669.jpg",
                    ImageUrlDetailed = "https://images.pexels.com/photos/462331/pexels-photo-462331.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
                }
                );
        }
    }
}
