import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TaxCalculatorService {
  private apiUrl = `${environment.apiUrl}/taxcalculator`;

  constructor(private http: HttpClient) { }

  calculateTax(salary: number) {
    return this.http.post<number>(this.apiUrl, salary);
  }
}
