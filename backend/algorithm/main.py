from credit_analyzer import credit_analyzer as ca
from fastapi import FastAPI
from api import models


app = FastAPI()


@app.post("/")
def get_data(in_data : models.Data):
    points = ca.get_risk_points(ca.parse_data(in_data.profile), in_data.creditHistory, in_data.dli)
    rate = ca.get_risk_level(points)
    return {
        "risk_points": points,
        "risk_level": rate
    }
