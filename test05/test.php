<?php

    if( $argc != 2 ){ echo("Run with parameter!\n"); return; }
    $counter = (int)$argv[1];

    $sum = 0;
    for($i=0;$i<$counter;$i++){
        for($j=0;$j<$counter;$j++){
            $sum += 1 + $i*2 + $j*3;
        }
    }
    printf("sum = %ld\n", $sum);

    if( $counter != 25000 ){ echo("Run with parameter of 25000 !\n"); }

?>
