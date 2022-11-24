This task was quite simple. Finding the angle between each hand by subtracting their absolute values (angle between a hand and the 12 numeral) is obvious.  

One thing to keep an eye out for, is that the hour hand moves every minute as well. So every minute of an hour adds 1/60th of one hour cricle segment to the hour hand.
This tiny addition is represented by *hourFraction* in the code. Hours are modulo 12 to cover any hour value (e.g. 24 hour format)
