<?php
print "Hello World! \n";        // Things can be printed in two ways
echo  "Hello World! \n";        // echo is marginally quicker than print

$Var = "variable containing a 'Hello World' \n";
print $Var;

$Hello = 'Hello \n ';           // Variables can be put in each other
$World = "$Hello World! \n";    // "" and '' are not interchangeable like python,
                                // '' tells PHP to not to format
print "Printing with two variables: " . $World;
?>
