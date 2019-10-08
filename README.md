# SOLID-principles
examples of SOLID principles compared to bad design

# ISP = Interface Seggregation Principle
classes should not be depend on methods they do not use.

Example.
Two classes with similar functionaly *Bus* and *Car*:
 - You can print details about a vehicle
 - You can add new car but not a new bus. 

Bad design

![ISP bad design](https://www.dropbox.com/s/k2zexaqw7lcgjys/ISP_BadDesign.JPG?raw=1)

Good design

![ISP good design](https://www.dropbox.com/s/i2xjstwmg45ohly/ISP_GoodDesign.JPG?raw=1)
