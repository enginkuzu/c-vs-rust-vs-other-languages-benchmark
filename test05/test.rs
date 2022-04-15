use std::io;
use std::time::UNIX_EPOCH;
use std::time::SystemTime;
use std::collections::HashMap;

fn main() {

    let mut total:u64 = 0;
    let mut map = HashMap::new();

    let time1:u128 = SystemTime::now().duration_since(UNIX_EPOCH).expect("duration error").as_millis();
    for i in 0u32..25000000 {
        map.insert(i, i);
    }
    let time2:u128 = SystemTime::now().duration_since(UNIX_EPOCH).expect("duration error").as_millis();
    println!("HashMap put {} ms", time2-time1);

    let mut line = String::new();
    io::stdin().read_line(&mut line);

    let time3:u128 = SystemTime::now().duration_since(UNIX_EPOCH).expect("duration error").as_millis();
    for i in 0u32..25000000 {
        total += *map.get(&i).unwrap() as u64;
    }
    let time4:u128 = SystemTime::now().duration_since(UNIX_EPOCH).expect("duration error").as_millis();
    println!("total = {}", total);
    println!("HashMap get {} ms", time4-time3);

}

