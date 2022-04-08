<?php

    if( $argc != 2 ) goto end_with_error;
    $counter = (int)$argv[1];
    if( $counter != 25000 ) goto end_with_error;

    $sum = 0;
    for($i=0;$i<$counter;$i++){
        for($j=0;$j<$counter;$j++){
            $sum += 1 + $i*2 + $j*3;
        }
    }
    printf("sum = %ld\n", $sum);
    return;

end_with_error:
    echo("Run with parameter of 25000 !\n");

?>
