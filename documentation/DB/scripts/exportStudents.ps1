cd P:\Pre-TPI\DB
$csv = Import-Csv -Path "./students.csv" -Delimiter ";"

$table = @{"SI-C1a" = 1; "SI-C1b" = 2; "SI-C2a" = 3; "SI-C2b" = 4; "SI-C3a" = 5; "SI-C3b" = 6; "SI-C4a" = 7; "SI-C4b" = 8; "SI-C4r" = 9; "SI-CA1a" = 10; "SI-CA2a" = 11; "SI-MI1a" = 12; "SI-MI1b" = 13; "SI-MI2a" = 14; "SI-MI2b" = 15; "SI-MI3a" = 16; "SI-MI3b" = 17; "SI-MI4a" = 18; "SI-MI4b" = 19; "SM-CA1a" = 20; "SM-CA2a" = 21; "SP-CA1a" = 22; "SP-CA2a" = 23; "YA-CA1a" = 24; "YA-CA2a" = 25; "YAD-CA2a" = 26; "YAD-CA4a" = 27; "YS-CA2a" = 28; "YS-CA2b" = 29}

Foreach($line in $csv){
    $email = $line.Email
    $lastName = $line.Nom
    $firstName = $line.Prénom
    $class = $table[$line.Classe]

    $res = "('$($email)','$($lastName)','$($firstName)',$($class)),"

    echo $res
    Out-File -FilePath ./students.sql -Encoding utf8 -Append -InputObject $res
}