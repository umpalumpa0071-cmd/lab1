(*
open System
let A x n =
    [
        if  n > 0
            then 
                let spisok = List.replicate n x
                printf "итоговый список: %A" (spisok)
        else 
            printf "Ошибка! Вы ввели некорректное n"
    ]
[<EntryPoint>]
let main agrs =
    printf "введите элемент "
    let x = string(Console.ReadLine())
    printf "введите n "
    let n = int(Console.ReadLine())
    A x n
    0

    *)
let rec A x =
    if x = 0
    then 1
    else (x%10) * A(x/10)

[<EntryPoint>]
printf "введите число: "
let n = int(System.Console.ReadLine())
let b = A n
printf "Произведение цифр числа %d равно %d" n b


