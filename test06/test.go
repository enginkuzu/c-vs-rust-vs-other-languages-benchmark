package main
import "fmt"
import "time"

func main() {

    var i uint32;
    var total uint64 = 0;
    var hmap = make(map[uint32]uint32);

    time1 := time.Now().UnixNano()/1000000;
    for i=0; i<25000000; i++ {
        hmap[i] = i;
    }
    time2 := time.Now().UnixNano()/1000000;
    fmt.Println("HashMap put", (time2-time1), "ms");

    var tmp string
    fmt.Scanf("%s", &tmp)

    time3 := time.Now().UnixNano()/1000000;
    for i=0; i<25000000; i++ {
        total += uint64(hmap[i]);
    }
    time4 := time.Now().UnixNano()/1000000;
    fmt.Println("total =", total);
    fmt.Println("HashMap get", (time4-time3), "ms");

}

