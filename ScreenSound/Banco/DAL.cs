using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScreenSound.Modelos;

namespace ScreenSound.Banco;

internal class DAL<T> where T : class
{
    protected readonly ScreenSoundContext _context;

    public DAL(ScreenSoundContext context)
    {
        _context = context;
    }

    public IEnumerable<T> List()
    {
        return _context.Set<T>().ToList();
    }
    public T? GetBy(Func<T, bool> condiction)
    {
        return _context.Set<T>().FirstOrDefault(condiction);
    }

    public IEnumerable<T> SearchBy(Func<T, bool> condiction)
    {
        return _context.Set<T>().Where(condiction);
    }
    public void Save(T objeto)
    {
        _context.Set<T>().Add(objeto);
        _context.SaveChanges();
    }
    public void Put(T objeto)
    {
        _context.Set<T>().Update(objeto);
        _context.SaveChanges();
    }
    public void Deletar(T objeto)
    {
        _context.Set<T>().Remove(objeto);
        _context.SaveChanges();
    }
}
