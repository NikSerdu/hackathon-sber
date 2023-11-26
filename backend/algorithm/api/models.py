from fastapi import FastAPI
from pydantic import BaseModel


class Data(BaseModel):
    profile: list
    creditHistory: str
    dli: float