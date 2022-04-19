<?php

    $total = 0;
    $map = array();

    $time1 = round(microtime(true) * 1000);
    for($i=0;$i<25000000;$i++){
        $map[$i] = $i;
    }
    $time2 = round(microtime(true) * 1000);
    echo "HashMap put ".($time2-$time1)." ms\n";

    readline();

    $time3 = round(microtime(true) * 1000);
    for($i=0;$i<25000000;$i++){
        $total += $map[$i];
    }
    $time4 = round(microtime(true) * 1000);
    echo "total = ".$total."\n";
    echo "HashMap get ".($time4-$time3)." ms\n";

?>
