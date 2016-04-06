class Calendar(object):
    months = (31, 28, 31, 30, 31, 30, 31, 30, 31, 30, 31, 30)
    date_style = "British"
    
    @staticmethod
    def leapyear(year):
        if (year % 4 == 0):
            if (year % 100 == 0):
                # divisible by 4 and by 100
                if (year % 400 == 0):
                    leapyear = True
                else: 
                    leapyear = False
            else: 
                # divisible by 4 but not by 100
                leapyear = True
        else:
            #not divisible by 4 
            leapyear = False
        return leapyear
        
    def __init__(self, d, m, y):
        self.setCalendar(d, m, y)
        
    def setCalendar(d, m, y): 
        if type(d) == int and type(m) == int and type(y) == int:
            self.__days = d
            self.__months = m
            self.__years = y
        else:
            raise TypeError("must be integers")
            
    def __str__(self):
        if Calendar.date_style == "British":
            return "{0:02d}/{1:02d}/{2:4d}".format(self.__days, self.__monts, self.__years)
        else:
            return "{0:02d}/{1:02d}/{2:4d}".format(self.__monts, self.__days, self.__years)
            
    def advance(self):
        max_days = Calendar.months[self.__months-1]
        if self.__months == 2 and Calendar.leapyear(self.__years):
            max_days += 1
        if self.__days == max_days:
            self.__days = 1
            if self.__months == 12:
                self.__months = 1
                self.__years += 1
            else: 
                self.__months += 1
        else: 
            self.__days += 1 