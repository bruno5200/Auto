import request

def send(placa, directoro):
    payload = { 'placa' : placa, 'dir': directorio}
    res = requests.post('https://127.0.0.1:8000/api/auto', data=payload)

return res.status_code
