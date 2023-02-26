# UnityScripting
In this project -  I work on game developer techniques in scripting etc.


## Variables


### Protection Type
- "Like " Boxes that contain data Variables are able to store data inside

[] image

different variables to tweak this game object
(speed, damage, health)
First specify PUBLIC or PRIVATE of this variable

In this example - private is only accessible from within the script

```csharp
private int speed;
```


In this example - a public is accessible from any scripts
```csharp
public float health;

```
Also, public is allowed to be tweaked from inside the inspector of Unity
[] image

### Type of


```csharp

float
string
int
bool
Components


```
Floats are specified numbers for example {2.5, 4.1, 3.5, 9.1}
[] image
Strings, think of a one character 'c' and now you have a chain of characters creating a string {"hello", "how are you?"}
[] image
Int is a whole number ranging from negatives to postives {-4, -6, 0, 1, 9, 10}
[] image
Bool will give you either true or false
[] image
Components in the inspector can modify them {Rigid body, transform, etc..}
