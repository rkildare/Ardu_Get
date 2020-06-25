# Ardu_Get
Recieves serial data from an arduino (<b>or any serial device</b>), saves it to a file, and graphs it (if it is sent to the PC in a csv format).

Works similar to the serial monitor/plotter included with the arduino IDE. It will graph data if it is sent in CSV format, e.g. "1,2,3,4\n" 
Note: The newline character "\n" is required to create a new line within the output monitor/.csv file; it is also used to have the graph plot each set of data points.
    -If you are using an arduino, please use "Serial.print" or "Serial.println". Serial.println will add the '\n' automatically.
