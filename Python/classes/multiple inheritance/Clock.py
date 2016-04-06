class Clock(object):
 
    def __init__(self, hours, minutes, seconds):
        self.setClock(hours, minutes, seconds)        
        
    def setClock(self, hours, minutes, seconds):
        if type(hours) == int and 0 <= hours and hours < 24:
            self._hours = hours
        else:
            raise TypeError("Hours must be valid int")   
        if type(minutes) == int and 0 <= minutes and minutes < 60:
            self._minutes = minutes
        else: 
            raise TypeError("minutes must be valid int")
        if type(seconds) == int and 0 <= seconds and seconds < 60:
            self._seconds = seconds
        else:
            raise TypeError("Seconds must be valid int") 
            
    def __str__(self):
        return "{0:02d}:{1:02d}:{2:02d}".format(self._hours, self._minutes, self._seconds)
        
    def tick():
        if self._seconds == 59:
            self._seconds = 0
            if self._minutes == 59:
                self._minutes = 0
                if self._hours == 23:
                    self._hours = 0
                else
                    self._hours += 1
            else 
                self._minutes += 1
        else 
            self._seconds += 1        
          