import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Jogo } from '../models/Jogo';
import { MensagemService } from './mensagem.service';
import { map, catchError } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class JogoService {

  baseURL = `${environment.mainUrlAPI}jogo`;

  constructor(
    private http: HttpClient,
    private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<Jogo[]> {
    return this.http.get<Jogo[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<Jogo> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<Jogo>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(jogo: Jogo): Observable<Jogo> {
    return this.http.post<Jogo>(this.baseURL, jogo).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    console.log(e);
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Jogo!', true);
    return EMPTY;
  }

}
