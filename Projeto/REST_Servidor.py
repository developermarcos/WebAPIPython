'''
pip install flask
pip install flask-restful

criar (POST), alterar (PUT), apagar (DELETE), listar (GET)

curl -X GET http://127.0.0.1:5000/user/1
curl -X POST http://127.0.0.1:5000/user/5 -H 'Content-Type: application/json' -d '{"nome":"dggdgd2","idade":90}'
curl -X PUT http://127.0.0.1:5000/user/5 -H 'Content-Type: application/json' -d '{"nome":"novo nome","idade":25}' 
curl -X DELETE http://127.0.0.1:5000/user/1
'''

#coding: utf-8
from flask import Flask, jsonify
from flask_restful import Api, Resource, reqparse

app = Flask(__name__)
api = Api(app)

usuarios = [
    {
        "id": 1,
        "nome": "Abc",
        "idade": 42
    },
    {
        "id": 2,
        "nome": "Bolinhas",
        "idade": 32
    },
    {
        "id": 3,
        "nome": "Uniplac",
        "idade": 22
    }
]


class User(Resource):

    def get(self, id):
        if(id == 0):
            return jsonify(usuarios)
        else:
            for user in usuarios:
                if(id == user["id"]):
                    return user, 200
            msg = {"msg": "Usuário não encontrado"}
            return msg, 404

    def post(self, id):
        parser = reqparse.RequestParser()
        parser.add_argument("nome")
        parser.add_argument("idade")
        args = parser.parse_args()

        for user in usuarios:
            if(id == user["id"]):
                msg = {"msg": "Usuário com id {} já existe".format(id)}
                return msg, 400

        user = {
            "id": id,
            "idade": args["idade"],
            "nome": args["nome"]
        }
        usuarios.append(user)
        return user, 201

    def put(self, id):
        parser = reqparse.RequestParser()
        parser.add_argument("nome")
        parser.add_argument("idade")
        args = parser.parse_args()

        for user in usuarios:
            if(id == user["id"]):
                user["nome"] = args["nome"]
                user["idade"] = args["idade"]
                return user, 200
        msg = {"msg": "Usuário com id {} não localizado".format(id)}
        return msg, 404

    def delete(self, id):
        global usuarios
        usuarios = [user for user in usuarios if user["id"] != id]
        msg = {"msg": "{} deletado.".format(id)}
        return msg, 200


api.add_resource(User, "/user/<int:id>")


app.run(debug=True)
