<?php
    $sum = 0;
    for($i=0;$i<25000;$i++){
        for($j=0;$j<25000;$j++){
            $sum += 1 + $i*2 + $j*3;
        }
    }
    printf("sum = %ld\n", $sum);
?>
