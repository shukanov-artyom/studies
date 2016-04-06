from Clock import Clock
from Calendar import Calendar

class CalendarClock(clock, Calendar):
    def __init__(self, day, month, year, hour, minute, second):
        Clock.__init__(self, hour, minute, second)
        Calendar.__init__(self, day, monts, year)
        
    def tick(self):
        previous_hour = self.hours
        Clock.tick(self)
        if self._hours < previous_hour:
            self.advance()
            
    def __str__(self):  
        return Calendar.__str__(self) + ", " + Clock.__str__(self)