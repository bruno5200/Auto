import request

def send(placa, directoro):
    payload = { 'placa' : placa, 'dir': directorio}
    res = requests.post('https://localhost:5000/api/auto', data=payload)

return res.status_code
