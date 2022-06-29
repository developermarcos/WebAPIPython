<?php
    class ModelClienteAPI
    {
        public $url = "http://localhost";
        public $port = "5000";
        public $request = [
            'GET' => 'GET',
            'POST' => 'POST',
            'PUT' => 'PUT',
            'DELETE' => 'DELETE'
        ];

        public function ValidaCpf($cpf){
            return $this->ExecuteCommand("validacpf", $this->request['POST'], $cpf, "");
        }

        public function SelectByID($id){
            return $this->ExecuteCommand("user", $this->request['GET'], $id, "");
        }

        public function Delete($id){
            return $this->ExecuteCommand("user", $this->request['DELETE'], $id, "");
        }

        public function Insert($object, $id){
            return $this->ExecuteCommand("user", $this->request['POST'], $id, $object);
        }

        public function Edit($object, $id){
            return $this->ExecuteCommand("user", $this->request['PUT'], $id, $object);
        }

        private function ExecuteCommand($metodo, $request, $id, $object){
            $header =[
                'content-type: application/json'
            ];

            $json = json_encode($object);

            $url = "$this->url:$this->port/$metodo/$id";
            var_dump($url);
            $curl = curl_init();
            curl_setopt_array($curl, [
            CURLOPT_PORT => $this->port,
            CURLOPT_URL => $url,
            CURLOPT_RETURNTRANSFER => true,
            CURLOPT_ENCODING => "",
            CURLOPT_MAXREDIRS => 10,
            CURLOPT_TIMEOUT => 30,
            CURLOPT_HTTP_VERSION => CURL_HTTP_VERSION_1_1,
            CURLOPT_CUSTOMREQUEST => $request,
            CURLOPT_POSTFIELDS => $json,
            CURLOPT_HTTPHEADER => $header
            ]);
            
            $response = curl_exec($curl);
            $err = curl_error($curl);

            curl_close($curl);

            if ($err) {
                return "cURL Error #:" . $err;
            } else {
                return $response;
            }
        }
    }

?>