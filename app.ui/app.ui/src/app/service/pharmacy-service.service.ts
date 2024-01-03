import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Pharmacy } from 'src/app/model/pharmacy-model';
import { Observable, catchError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PharmacyService {

  constructor(private http: HttpClient) { }

  getPharmacyApi(): Observable<Pharmacy[]> {
    return this.http.get<Pharmacy[]>("/Pharmacy")
  }

  updatePharmacy(pharmacy: Pharmacy): Observable<string> {
    const httpOptions = {
      headers: new HttpHeaders({
        'Content-Type':  'application/json',
        'accept': 'text/plain',
        'Access-Control-Allow-Origin': '*',
        'Access-Control-Allow-Credentials': 'true',
        'Access-Control-Allow-Headers': 'Content-Type',
        'Access-Control-Allow-Methods': 'GET,PUT,POST,DELETE',
      })
    };
    let updateUrl = 'https://localhost:7114/Pharmacy/'+ pharmacy.pharmacyId;
    return this.http.put<string>(updateUrl,JSON.stringify(pharmacy) ,httpOptions)
  }

}
