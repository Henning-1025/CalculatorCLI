CREATE Calculator class
  METHOD Add(number1, number2)
    RETURN number1 + number2
  
  METHOD Add(array of numbers)
    sum = 0
    FOR EACH number in array
      sum = sum + number
    RETURN sum

MAIN Program
  CREATE calculator instance
  running = true
  
  WHILE running
    DISPLAY menu
    GET user choice
    
    IF choice is exit
      running = false
      CONTINUE
    
    GET numbers as string from user
    SPLIT string by comma/space
    CONVERT each piece to double
    STORE in list/array
    
    IF count equals 2
      CALL two-parameter overload
    ELSE
      CALL array overload
    
    DISPLAY result