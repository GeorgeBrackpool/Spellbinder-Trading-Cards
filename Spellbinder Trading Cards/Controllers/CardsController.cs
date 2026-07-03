
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpellbinderTradingCards.Models;
using SpellbinderTradingCards.Data;


namespace SpellbinderTradingCards.Controllers;
public class CardsController : Controller
{
    private readonly ApplicationDbContext _context;

    public CardsController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: CARDS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Cards.ToListAsync());
    }

    // GET: CARDS/Details/5
    public async Task<IActionResult> Details(int? cardid)
    {
        if (cardid == null)
        {
            return NotFound();
        }

        var card = await _context.Cards
            .FirstOrDefaultAsync(m => m.CardId == cardid);
        if (card == null)
        {
            return NotFound();
        }

        return View(card);
    }

    // GET: CARDS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CARDS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CardId,Name,Price,ImageUrl,BrandId,Brand,Description,RarityId,Rarity,ConditionId,Condition,OrderItem,CartItem,SetId,Set,StockQuantity,CreatedDate")] Card card)
    {
        if (ModelState.IsValid)
        {
            _context.Add(card);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(card);
    }

    // GET: CARDS/Edit/5
    public async Task<IActionResult> Edit(int? cardid)
    {
        if (cardid == null)
        {
            return NotFound();
        }

        var card = await _context.Cards.FindAsync(cardid);
        if (card == null)
        {
            return NotFound();
        }
        return View(card);
    }

    // POST: CARDS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? cardid, [Bind("CardId,Name,Price,ImageUrl,BrandId,Brand,Description,RarityId,Rarity,ConditionId,Condition,OrderItem,CartItem,SetId,Set,StockQuantity,CreatedDate")] Card card)
    {
        if (cardid != card.CardId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(card);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CardExists(card.CardId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(card);
    }

    // GET: CARDS/Delete/5
    public async Task<IActionResult> Delete(int? cardid)
    {
        if (cardid == null)
        {
            return NotFound();
        }

        var card = await _context.Cards
            .FirstOrDefaultAsync(m => m.CardId == cardid);
        if (card == null)
        {
            return NotFound();
        }

        return View(card);
    }

    // POST: CARDS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? cardid)
    {
        var card = await _context.Cards.FindAsync(cardid);
        if (card != null)
        {
            _context.Cards.Remove(card);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool CardExists(int? cardid)
    {
        return _context.Cards.Any(e => e.CardId == cardid);
    }
}
