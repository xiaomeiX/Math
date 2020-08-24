# Math
Description A windows console application that reads an xml file and performs mathematical calculations for the users. 
Use case  
1. The user double clicks Mathml.exe 
2. A console window appears 
3. Displays calculations to user 
4. Closes when the user presses ENTER 
 
 
Example output:
“Username – OperationName:  Value1 <OperationOperator> Value2” 
Joe – SUM:  40 + 2 = 42 
Sam – MULTIPLY:  3 * 2 = 6 

Example XML 
<Operations>
    <Add>
        <Description>Joe;SUM;TURN10</Description>
        <Value1>40</Value1>
        <Value2>2</Value2>
    </Add>
    <Multiply>
        <Description>Sam;MULTIPLY;TURN10</Description>
        <Value1>2</Value1>
        <Value2>3</Value2>
    </Multiply>
    <Subtract>
        <Description>Joe;SUB;TURN10</Description>
        <Value1>100</Value1>
        <Value2>54</Value2>
    </Subtract>
    <Divide>
        <Description>Susan;DIVIDE;</Description>
        <Value1>50</Value1>
        <Value2>2</Value2>
    </Divide>
   
</Operations>
