use std::env;
fn main() {

    let args:Vec<String> = env::args().collect();
    if args.len() != 2 {
        println!("Run with parameter!");
        return;
    }
    let counter:u32 = args[1].parse().unwrap_or(0);

    let mut sum:u64 = 0;
    for i in 0u32..counter {
        for j in 0u32..counter {
            sum += (1 + i*2 + j*3) as u64;
        }
    }
    println!("sum = {}", sum);

    if counter != 25000 {
        println!("Run with parameter of 25000 !");
    }

}

