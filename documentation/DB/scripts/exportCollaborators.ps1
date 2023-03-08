cd P:\Pre-TPI\DB
$csv = Import-Csv -Path "./collaborators.csv" -Delimiter ";"

Foreach($line in $csv){
    $email = $line.Email
    $acronym = $line.Acronyme
    $lastName = $line.Nom
    $firstName = $line.Prénom
    $isResp = 0

    $res = "('$($email)','$($acronym)','$($lastName)','$($firstName)',$($isResp)),"

    #echo $res
    Out-File -FilePath ./collaborators.sql -Encoding utf8 -Append -InputObject $res
}