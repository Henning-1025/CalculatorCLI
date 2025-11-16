# Pseudocode

## Calculator Class

```
Add(numbers)
  result = 0
  FOR EACH number
    result = result + number
  RETURN result

Subtract(numbers)
  result = numbers[0]
  FOR i = 1 to end
    result = result - numbers[i]
  RETURN result

Multiply(numbers)
  result = numbers[0]
  FOR i = 1 to end
    result = result * numbers[i]
  RETURN result

Divide(numbers)
  result = numbers[0]
  FOR i = 1 to end
    IF numbers[i] = 0 THEN ERROR
    result = result / numbers[i]
  RETURN result
```

## Main Program

```
WHILE running
  Display menu
  Get choice
  
  IF choice = exit THEN STOP
  
  Get numbers from user
  Parse numbers
  
  SWITCH choice
    CASE add: result = Add(numbers)
    CASE subtract: result = Subtract(numbers)
    CASE multiply: result = Multiply(numbers)
    CASE divide: result = Divide(numbers)
  
  Display result
END WHILE
```