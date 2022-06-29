package main

import (
	"encoding/json"
	"fmt"
	"io/ioutil"
	"net/http"
	"strconv"
	"strings"
)

type Todo struct {
	Id    int    `json: "id"`
	Nome  string `json:"nome"`
	Idade int    `json:"idade"`
}

func main() {

	var option int
	for true {
		fmt.Println("Qual operação deseja executar? 1-POST, 2-GET, 3-PUT, 4-DELETE ou 5-Validar CPF:")
		fmt.Scanln(&option)
		var id int
		var cpf int
		if option == 1 {
			fmt.Println("Informe Id:")
			fmt.Scanln(&id)
			post(id)
		} else if option == 2 {
			fmt.Println("Informe Id:")
			fmt.Scanln(&id)
			get(id)
		} else if option == 3 {
			fmt.Println("Informe Id:")
			fmt.Scanln(&id)
			put(id)
		} else if option == 4 {
			fmt.Println("Informe Id:")
			fmt.Scanln(&id)
			delete(id)
		} else if option == 5 {
			fmt.Println("Informe Id:")
			fmt.Scanln(&cpf)
			validacpf(cpf)
		}

	}

}

func get(id int) {
	url := "http://127.0.0.1:5000/user/" + strconv.Itoa(id)

	req, _ := http.NewRequest("GET", url, nil)

	res, _ := http.DefaultClient.Do(req)

	defer res.Body.Close()
	body, _ := ioutil.ReadAll(res.Body)

	fmt.Println(res)
	fmt.Println(string(body))

}

func post(id int) {

	url := "http://127.0.0.1:5000/user/" + strconv.Itoa(id)

	var nome string
	var idade int

	fmt.Println("Informe o Nome:")
	fmt.Scanln(&nome)
	fmt.Println("Informe a idade:")
	fmt.Scanln(&idade)

	todo := &Todo{Id: id, Nome: nome, Idade: idade}

	jsonReq, _ := json.Marshal(todo)

	payload := strings.NewReader(string(jsonReq))
	req, _ := http.NewRequest("POST", url, payload)

	req.Header.Add("Content-Type", "application/json")

	res, _ := http.DefaultClient.Do(req)

	defer res.Body.Close()
	body, _ := ioutil.ReadAll(res.Body)

	fmt.Println(res)
	fmt.Println(string(body))
}

func put(id int) {
	url := "http://127.0.0.1:5000/user/" + strconv.Itoa(id)

	var nome string
	var idade int

	fmt.Println("Informe o Nome:")
	fmt.Scanln(&nome)
	fmt.Println("Informe a idade:")
	fmt.Scanln(&idade)

	todo := &Todo{Id: id, Nome: nome, Idade: idade}

	jsonReq, _ := json.Marshal(todo)

	payload := strings.NewReader(string(jsonReq))

	req, _ := http.NewRequest("PUT", url, payload)

	req.Header.Add("Content-Type", "application/json")

	res, _ := http.DefaultClient.Do(req)

	defer res.Body.Close()
	body, _ := ioutil.ReadAll(res.Body)

	fmt.Println(res)
	fmt.Println(string(body))

}

func delete(id int) {
	url := "http://127.0.0.1:5000/user/" + strconv.Itoa(id)

	req, _ := http.NewRequest("DELETE", url, nil)

	res, _ := http.DefaultClient.Do(req)

	defer res.Body.Close()
	body, _ := ioutil.ReadAll(res.Body)

	fmt.Println(res)
	fmt.Println(string(body))

}

func validacpf(cpf int) {
	url := "http://127.0.0.1:5000/validacpf/" + strconv.Itoa(cpf)

	req, _ := http.NewRequest("POST", url, nil)

	res, _ := http.DefaultClient.Do(req)

	defer res.Body.Close()
	body, _ := ioutil.ReadAll(res.Body)

	fmt.Println(res)
	fmt.Println(string(body))

}
